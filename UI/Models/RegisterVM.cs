using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Adınızı qeyd edin")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyadınızı qeyd edin")]

        public string Surname { get; set; }

        [Required(ErrorMessage = "E-poçt adresinizi qeyd edin")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "İstifadəçi adınızı qeyd edin")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Şifrə boş olmamalıdır")]

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Təkrar şifrəni düzgün qeyd edin")]

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }

       public int DepartmentID { get; set; }
       public int RoleId { get; set; }

        //public List<Department> Departments { get; set; } 


    }
}
