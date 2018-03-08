using Microsoft.AspNetCore.Identity;
using RPG_Manager.Areas.RPGArea.Models;
using RPG_Manager.Areas.RPGArea.Models.Authorizational_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Areas.RPGArea.Data
{
    public class DBInit
    {
        public static void Init(CharacterContext con, UserManager<ApplicationUser> um, RoleManager<IdentityRole> rm)
        {
            con.Database.EnsureCreated();

            if (con.Account.Any() && con.Campaign.Any() && con.Character.Any())
                return;

            var role = new IdentityRole() { Name = "Admin" };
            var res = rm.CreateAsync(role).Result;

            role = new IdentityRole() { Name = "User" };
            res = rm.CreateAsync(role).Result;

            var user = new ApplicationUser { UserName = "h3rz3l24o1@gmail.com", Email = "h3rz3l24o1@gmail.com" };
            res = um.CreateAsync(user, "Password_123").Result;
            res = um.AddToRoleAsync(user, "Admin").Result;

            var normuser = new ApplicationUser { UserName = "user@benutzer.com", Email = "user@benutzer.com" };
            res = um.CreateAsync(user, "Password_123").Result;
            res = um.AddToRoleAsync(user, "User").Result;

            con.SaveChanges();
        }
    }
}
