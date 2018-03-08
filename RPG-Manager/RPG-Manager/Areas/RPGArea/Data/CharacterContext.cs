using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RPG_Manager.Areas.RPGArea.Models;
using RPG_Manager.Areas.RPGArea.Models.Authorizational_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Areas.RPGArea.Data
{
    public class CharacterContext : IdentityDbContext<ApplicationUser>
    {
        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options) { }

        public DbSet<Character> Character { get; set; }
        public DbSet<Register> Account { get; set; }
        public DbSet<Campaign> Campaign { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
            mb.Entity<Character>().ToTable("Character");
            mb.Entity<Register>().ToTable("Account");
            mb.Entity<Campaign>().ToTable("Campaign");
        }
    }
}
