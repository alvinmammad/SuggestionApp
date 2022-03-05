using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage ="İstifadəçi adını daxil edin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifrəni daxil edin")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnURL { get; set; }
    }
}
