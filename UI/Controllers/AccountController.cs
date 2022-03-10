
using Business.Abstract;
using Business.Concrete;
using Microsoft.EntityFrameworkCore;

using DAL.Concrete.EFCore;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UI.Models;
using UI.EmailService;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc.Rendering;
using Business.ValidationRules;
using FluentValidation.Results;

namespace UI.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
       
        private IFeedbackService _feedbackService;
        private IUserService _userService;
        private IDepartmentService _departmentService;
        private IFeedbackCategoryService _feedbackCategoryService;
        private IEmailSender _emailSender;
        private readonly BankDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        public AccountController(
                                BankDBContext context,
                                UserManager<AppUser> userManager,
                                SignInManager<AppUser> signInManager,
                                RoleManager<AppRole> roleManager,
                                IFeedbackService feedbackService,
                                IUserService userService,
                                IDepartmentService departmentService,
                                IFeedbackCategoryService feedbackCategoryService,
                                IEmailSender emailSender)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
            this._feedbackService = feedbackService;
            this._context = context;
            this._emailSender = emailSender;
            this._userService = userService;
            this._departmentService = departmentService;
            this._feedbackCategoryService = feedbackCategoryService;
        }
        public int GetCurrentUserID(string userIdentityName)
        {
            var currentUserID = _userManager.Users
               .Where(u => u.UserName == userIdentityName)
               .FirstOrDefault().Id;
            return currentUserID;
        }
        //Get all feedbacks
        [Authorize(Roles ="Admin,Secretary")]
        public IActionResult Index()
        {
            var feedbacks = _feedbackService.GetFeedbacksWithCategory();
            return View(feedbacks);
        }
        //Get feedback detail
        [Authorize(Roles = "Secretary")]
        public IActionResult FeedbackDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var feedback = _feedbackService.CheckFeedbackNote(id);
            if (feedback == null)
            {
                return NotFound();
            }
            return View(feedback);
        }
        [Authorize(Roles = "Secretary")]
        // Send the feedback to the department to which it belongs
        public IActionResult SendToHR(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var feedback = _feedbackService.GetFeedbackWithCategory(id);
            if (feedback == null)
            {
                TempData["NotFoundFeedback"] = "Daxil edilən ID-yə uyğun feedback mövcud deyil"; ;
                return RedirectToAction("index", "account");
            }
            var departmentID = feedback.FeedbackCategory.DepartmentID;
            var user = _feedbackService.GetHRRole(departmentID);
            if (user == null)
            {
                TempData["NotFoundUser"] = "Bu şöbə üçün HR mövcud deyil";
                return RedirectToAction("index", "account");
            }
            UserFeedback userFeedback = new UserFeedback();
            userFeedback.FeedbackID = feedback.ID;
            userFeedback.AppUserID = user.Id;
            feedback.FeedbackStatus= Entity.Enums.FeedbackStatus.inProgress;
            _context.UserFeedbacks.Add(userFeedback);
            _context.Feedbacks.Update(feedback);
            _context.SaveChanges();
            TempData["SendToHRMessage"] = "Feedback müvafiq şöbənin HR-ına göndərildi!";
            return RedirectToAction("index", "account");
        }
        [HttpGet]
        [Authorize(Roles = "Secretary")]
        //Check feedback which sended from HR (GET)
        public IActionResult CheckFeedbackNote(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var feedback = _feedbackService.CheckFeedbackNote(id);
            return View(feedback);
        }
        //Check feedback which sended from HR (POST)

        [HttpPost]
        [Authorize(Roles = "Secretary")]

        public IActionResult CheckFeedbackNote(int FeedbackID,string secretaryNote)
        {
            if (FeedbackID == 0)
            {
                return NotFound();
            }
            var secretaryFeedback = _feedbackService.CheckFeedbackNotePost(FeedbackID, secretaryNote);
            _context.Feedbacks.Update(secretaryFeedback.Feedback);
            _context.SaveChanges();
            TempData["SecretaryNoteSended"] ="Mesajınız düzəliş edilməsi üçün HR-a göndərildi!";
            return RedirectToAction("Index", "Account");
        }
        [Authorize(Roles = "Secretary")]
        //Send approved feedback to customer
        public async Task<IActionResult> SendFeedbackToCustomer(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var customer = _feedbackService.GetCustomer(id);
           
            try
            {
                await _emailSender.SendEmailAsync(customer.Feedback.CustomerEmail, "Feedback cavabı", customer.HRNote);
                if (customer.Feedback.FeedbackStatus == Entity.Enums.FeedbackStatus.inProgress)
                {
                    customer.Feedback.FeedbackStatus = Entity.Enums.FeedbackStatus.Approved;

                }
                TempData["EmailSended"] = customer.FeedbackID + " ID nömrəli feedback sahibinə mail vasitəsilə göndərildi";

            }
            catch (Exception e)
            {
                TempData["MailException"] = e.Message;
            }
            customer.Feedback.EmailStatus = true;
            _context.Feedbacks.Update(customer.Feedback);
            _context.SaveChanges();
            return RedirectToAction("Index", "Account");
        }

        [Authorize(Roles ="Admin,HR")]
        //Feedback list for HR-s
        public IActionResult HRFeedbackList()
        {
            var currentUserID = GetCurrentUserID(User.Identity.Name);
            var feedback = _feedbackService.HRFeedbackList(currentUserID);
            return View(feedback);
        }
        //Feedback detail for HR (GET)
        [HttpGet]
        [Authorize(Roles = "HR")]

        public IActionResult HRFeedbackDetails(int id)
        {

            if (id == 0)
            {
                return NotFound();
            }
            var currentUserID = GetCurrentUserID(User.Identity.Name);
            var feedback = _feedbackService.GetHRFeedback(id, currentUserID);
            if (feedback == null)
            {
                return NotFound();
            }
            return View(feedback);
        }
        //Feedback detail for HR (POST)

        [HttpPost]
        [Authorize(Roles = "HR")]

        public IActionResult HRFeedbackDetails(string HRNote,int FeedbackID)
        {
            if(HRNote==null && FeedbackID == 0)
            {
                return NotFound();
            }
            var currentUserID = GetCurrentUserID(User.Identity.Name);

            var userFeedback = _feedbackService.HRFeedbackDetails(HRNote, FeedbackID, currentUserID);
            TempData["HRNoteSended"] = "Mesajınız yoxlanılma üçün katibə göndərildi!";
            return RedirectToAction("HRFeedbackList", "Account");
            
        }
        //Delete feedback (only Secretary can delete feedback !)
        [Authorize(Roles ="Secretary")]
        public IActionResult DeleteFeedback(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var feedback = _feedbackService.GetByID(id);
            if (feedback == null)
            {
                return NotFound();
            }
            _feedbackService.Delete(feedback);
            TempData["DeleteSucceeded"] = "Feedback uğurla silindi";
            return RedirectToAction("Index", "Account");

        }

        
        #region Sign In
        [HttpGet]
        public IActionResult Login(string ReturnURL = null)
        {

            return View(new LoginVM()
            {
                ReturnURL = ReturnURL
            });
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            var user = await _userManager.FindByNameAsync(vm.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Bu istifadəçi adı ilə hesab tapılmadı");
                return View(vm);
            }
            var result = await _signInManager.PasswordSignInAsync(user, vm.Password, true, false);
            if (result.Succeeded)
            {
                return Redirect(vm.ReturnURL ?? "~/Account/Index");
            }
            
            ModelState.AddModelError("", "İstifadəçi adı və ya şifrə yanlışdır.");
            return View(vm);

        }
        #endregion
        #region Sign Up
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public IActionResult Register()
        {
            ViewData["DepartmentID"] = new SelectList(_feedbackService.GetUserWithDepartments(), "ID", "DepName");
            ViewData["RoleList"] = new SelectList(_roleManager.Roles, "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Register(RegisterVM vm)
        {
           
            if (!ModelState.IsValid)
            {
                ViewData["DepartmentID"] = new SelectList(_feedbackService.GetUserWithDepartments(), "ID", "DepName");
                ViewData["RoleList"] = new SelectList(_roleManager.Roles, "Id", "Name");
                return View(vm);
            }

            var user = new AppUser()
            {
                FirstName = vm.FirstName,
                Surname = vm.Surname,
                UserName = vm.UserName,
                Email = vm.Email,
                DepartmentID=vm.DepartmentID
            };
            var role = _roleManager.Roles.Where(r => r.Id == vm.RoleId).FirstOrDefault().ToString();
            var result = await _userManager.CreateAsync(user, vm.Password);
          
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, role);
                ViewBag.Email = user.Email;
                TempData["NewUser"] = "İstifadəçi uğurla yaradıldı";
                return RedirectToAction("Index", "Account");
            }
            else
            {
              
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    ViewData["DepartmentID"] = new SelectList(_feedbackService.GetUserWithDepartments(), "ID", "DepName");
                    ViewData["RoleList"] = new SelectList(_roleManager.Roles, "Id", "Name");
                    return View(vm);
                }
            }
            ViewData["DepartmentID"] = new SelectList(_feedbackService.GetUserWithDepartments(), "ID", "DepName");
            ViewData["RoleList"] = new SelectList(_roleManager.Roles, "Id", "Name");
            return View(vm);
            
        }
        #endregion
        #region Logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        #endregion
        #region Role
        [Authorize(Roles = "Admin")]
        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateRole(RoleVM vm)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new AppRole(vm.Name));
                if (result.Succeeded)
                {
                    TempData["SuccessRole"] = "Vəzifə uğurla yaradıldı !";
                    return RedirectToAction("RoleList");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(vm);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            var members = new List<AppUser>();
            var nonMembers = new List<AppUser>();

            foreach (var user in _userManager.Users.ToList())
            {
                var list = await _userManager.IsInRoleAsync(user, role.Name)
                                ? members : nonMembers;
                list.Add(user);
            }

            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> EditRole(RoleEditVM vm)
        {
            if (ModelState.IsValid)
            {
                foreach (var userID in vm.IDsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userID);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, vm.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                        else
                        {
                             TempData["SuccessRole"] = "Seçilmiş istifadəçi seçilən vəzifə(vəzifələrə) tətbiq edildi!";
                            return RedirectToAction("RoleList", "Account");
                        }
                    }
                }

                foreach (var userID in vm.IDsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userID);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, vm.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }

                        else
                        {
                            TempData["SuccessRole"] = "Seçilmiş istifadəçi seçilən vəzifədən(vəzifələrdən) çıxardıldı!";
                            return RedirectToAction("RoleList", "Account");
                        }
                    }
                }
            }
            return Redirect("/account/editrole/" + vm.RoleID);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var role = await _roleManager.FindByIdAsync(id);
            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                TempData["DeletedRole"] = "Vəzifə uğurla silindi";
                return RedirectToAction("rolelist", "account");
            }
            TempData["DeletedRoleError"] = "Xəta baş verdi";
            return RedirectToAction("rolelist","account");
        }
        #endregion
        #region Access Denied
        public IActionResult AccessDenied()
        {
            return View();
        }
        #endregion
        public IActionResult UserList()
        {
            var users = _userService.GetAllUsers();
            return View(users);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteUser(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    TempData["UserDeleted"] =id+ " nömrəli istifadəçi uğurla silindi";
                }
                else {
                    return NotFound();
                }
            }
            else
            {
                ModelState.AddModelError("", "İstifadəçi tapılmadı");
            }
            return RedirectToAction("Userlist","Account");
        }
        [Authorize(Roles ="Admin")]
        public IActionResult DepartmentList()
        {
            var departments = _departmentService.GetAll();
            return View(departments);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]

        public IActionResult CreateDepartment()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]


        public IActionResult CreateDepartment(Department department)
        {
            DepartmentValidator departmentValidator = new DepartmentValidator();
            ValidationResult validationResult = departmentValidator.Validate(department);
            if (validationResult.IsValid)
            {
                
                    department = _departmentService.Create(department);
                    TempData["NewDepartment"] = "Şöbə uğurla yaradıldı";
                    return RedirectToAction("DepartmentList","Account");
            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(department);

            }
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]


        public IActionResult UpdateDepartment(int id)
        {
            Department department = _departmentService.GetByID(id);
            return View(department);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]

        public IActionResult UpdateDepartment([Bind("ID,DepName,CreatedDate")] Department department)
        {
            DepartmentValidator departmentValidator = new DepartmentValidator();
            ValidationResult validationResult = departmentValidator.Validate(department);
            if (validationResult.IsValid)
            {
                try
                {
                    department = _departmentService.Update(department);
                    TempData["EditDepartment"] = "Şöbə uğurla yeniləndi.";
                    return RedirectToAction("DepartmentList", "Account");
                }
                catch
                {

                }

            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(department);
            }
            return View(department);
        }
        [Authorize(Roles = "Admin")]

        public IActionResult DeleteDepartment(int id)
        {
            Department department = _departmentService.GetByID(id);
            try
            {
                var deletedDepartment = _departmentService.Delete(department);
                TempData["DeleteDepartment"] = "Şöbə uğurla silindi";
                return RedirectToAction("DepartmentList", "Account");

            }
            catch
            {

            }
           
            return RedirectToAction("DepartmentList","Account");
        }
        [Authorize(Roles = "Admin")]

        public IActionResult CategoryList()
        {
            var category = _feedbackCategoryService.GetCategories();
            return View(category);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]

        public IActionResult CreateCategory()
        {
            ViewData["DepartmentID"] = new SelectList(_departmentService.GetAll(), "ID", "DepName");
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]

        public IActionResult CreateCategory(FeedbackCategories feedbackCategories)
        {
            FeedbackCategoryValidator categoryValidator = new FeedbackCategoryValidator();
            ValidationResult validationResult = categoryValidator.Validate(feedbackCategories);
            if (validationResult.IsValid)
            {

                try
                {

                    feedbackCategories = _feedbackCategoryService.Create(feedbackCategories);
                    TempData["CategorySuccess"] = "Kateqoriya uğurla yaradıldı.";
                    return RedirectToAction("CategoryList","Account");

                }
                catch
                {

                }
            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                ViewData["DepartmentID"] = new SelectList(_departmentService.GetAll(), "ID", "DepName");

                return View(feedbackCategories);
            }

            ViewData["DepartmentID"] = new SelectList(_departmentService.GetAll(), "ID", "DepName");


            return View(feedbackCategories);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]

        public IActionResult UpdateCategory(int id)
        {
            FeedbackCategories category= _feedbackCategoryService.GetCategory(id);
            ViewData["DepartmentID"] = new SelectList(_departmentService.GetAll(), "ID", "DepName");

            return View(category);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]

        public IActionResult UpdateCategory([Bind("ID,CategoryName,DepartmentID,CreatedDate")] FeedbackCategories feedbackCategories)
        {
            FeedbackCategoryValidator categoryValidator = new FeedbackCategoryValidator();
            ValidationResult validationResult = categoryValidator.Validate(feedbackCategories);
            if (validationResult.IsValid)
            {
                try
                {
                    feedbackCategories = _feedbackCategoryService.Update(feedbackCategories);
                    TempData["EditCategory"] = "Kateqoriya uğurla yeniləndi.";
                    return RedirectToAction("CategoryList","Account");

                }
                catch
                {

                }

            }
            else
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                ViewData["DepartmentID"] = new SelectList(_departmentService.GetAll(), "ID", "DepName");

                return View(feedbackCategories);
            }
            ViewData["DepartmentID"] = new SelectList(_departmentService.GetAll(), "ID", "DepName");

            return View(feedbackCategories);

        }
        [Authorize(Roles = "Admin")]

        public IActionResult DeleteCategory(int id)
        {
            FeedbackCategories category = _feedbackCategoryService.GetCategory(id);
            try
            {
                var deletedCategory = _feedbackCategoryService.Delete(category);
                TempData["DeletedCategory"] = "Kateqoriya uğurla silindi";
                return RedirectToAction("CategoryList", "Account");

            }
            catch
            {

            }

            return RedirectToAction("CategoryList", "Account");
        }

    }
}
