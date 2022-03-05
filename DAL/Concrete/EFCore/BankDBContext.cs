using Entity;
using Entity.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EFCore
{
   public class BankDBContext:IdentityDbContext<AppUser,AppRole,int, IdentityUserClaim<int>, AppUserRole, IdentityUserLogin<int>,
IdentityRoleClaim<int>, IdentityUserToken<int>>
   {
        public BankDBContext()
        {
        }

        public BankDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<FeedbackCategories> FeedbackCategories { get; set; }
        public DbSet<UserFeedback> UserFeedbacks { get; set; }

        //public DbSet<AppUserRoles> AppUserRoles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-2NJCST5\\SQLEXPRESS; Initial Catalog = BankApp_New; Integrated security = SSPI;");

            }

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder
            //    .Entity<Feedback>()
            //    .Property(e => e.FeedbackStatus)
            //    .HasConversion(
            //     v => Convert.ToInt32(v),
            //     v => (FeedbackStatus)Enum.Parse(typeof(FeedbackStatus), v));

            builder.Entity<Feedback>()
                .HasOne(f => f.FeedbackCategory)
                .WithMany(fc => fc.Feedbacks);

            builder.Entity<FeedbackCategories>()
                .HasMany(fc => fc.Feedbacks)
                .WithOne(f => f.FeedbackCategory);

            builder.Entity<AppUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId);

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId);
            });
        }

    }
}
