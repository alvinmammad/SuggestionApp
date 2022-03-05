using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Models
{
    public class RoleVM
    {
        [Required]
        public string Name { get; set; }
    }

    public class RoleEditVM
    {
        public string RoleID { get; set; }
        public string RoleName { get; set; }
        public string[] IDsToAdd { get; set; }
        public string[] IDsToDelete { get; set; }
    }

    public class RoleDetails
    {
        public AppRole Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }
    }
}
