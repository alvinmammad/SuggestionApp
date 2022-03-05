using Business.Abstract;
using Business.ValidationRules;
using Entity;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private IFeedbackService _feedbackService;
        private IFeedbackCategoryService _feedbackCategoryService;
        
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger,IFeedbackService feedbackService, IFeedbackCategoryService feedbackCategoryService)
        {
            this._logger = logger;
            this._feedbackService = feedbackService;
            this._feedbackCategoryService = feedbackCategoryService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            List<SelectListItem> categoryValues = (from x in _feedbackCategoryService.GetFeedbackCategories()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.ID.ToString()
                                                   }).ToList();
            ViewBag.category = categoryValues;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Feedback feedback,IFormFile file)
        {
            FeedbackValidator feedbackValidator = new FeedbackValidator();
            ValidationResult validationResult = feedbackValidator.Validate(feedback);
            if (validationResult.IsValid)
            {

                if (file != null)
                {
                    var extension = Path.GetExtension(file.FileName);
                    var randName = string.Format($"{Guid.NewGuid()}{extension}");
                    feedback.FeedbackFile = randName;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", randName);
                    using(var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                feedback.FeedbackStatus = 0;
                _feedbackService.Create(feedback);
                TempData["Success"] = "Təklifiniz uğurla göndərildi";
                List<SelectListItem> categoryValues = (from x in _feedbackCategoryService.GetFeedbackCategories()
                                                       select new SelectListItem
                                                       {
                                                           Text = x.CategoryName,
                                                           Value = x.ID.ToString()
                                                       }).ToList();
                ViewBag.category = categoryValues;
                return View();
            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                List<SelectListItem> categoryValues = (from x in _feedbackCategoryService.GetFeedbackCategories()
                                                       select new SelectListItem
                                                       {
                                                           Text = x.CategoryName,
                                                           Value = x.ID.ToString()
                                                       }).ToList();
                ViewBag.category = categoryValues;
                return View(feedback);

            }

            
        }

       
    }
}
