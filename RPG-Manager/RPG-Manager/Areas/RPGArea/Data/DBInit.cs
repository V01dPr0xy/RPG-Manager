using Microsoft.AspNetCore.Identity;
using RPG_Manager.Areas.RPGArea.Models;
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

            var Accounts = new Account[]
            {
                new Account
                {
                    Email = "",
                    Name = "",
                    Password = "",
                    Username = "",
                    Characters = new List<Character>
                    {
                        new Character{ Name = "", Level = 1, Class = "Mage", Background = "", PlayerName = "", Age = 19, Alignment = "Chaotic Good", Appearance = "", XP = 9001, STR = 1, DEX = 1, CON=1, INT = 1, WIS=1, CHA=1, ArmorClass = 1, Initiative = 1, Speed=30, HitPointsMax = 1, HitPointsCurrent = 1 }
                    }
                }
            };
            var Campaigns = new Campaign[]
            {
            };
            var Characters = new Character[]
            {
            };

            foreach (Account a in Accounts)
                con.Account.Add(a);

            foreach (Campaign c in Campaigns)
                con.Campaign.Add(c);

            foreach (Character c in Characters)
                con.Character.Add(c);

            con.SaveChanges();
        }
    }
}
