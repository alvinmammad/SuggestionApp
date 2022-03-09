using DAL.Abstract;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EFCore
{
    public class EFCoreUserRepository : EFCoreGenericRepository<AppUser, BankDBContext>, IUserRepository
    {
        public List<AppUser> GetAllUsers()
        {
            using var c = new BankDBContext();
            var users = c.Users.Include(ud=>ud.Department).Include(u => u.UserRoles).ThenInclude(u => u.Role).ToList();
            return users;
        }
    }
}
