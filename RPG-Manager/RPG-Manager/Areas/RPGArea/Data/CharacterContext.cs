using Microsoft.EntityFrameworkCore;
using RPG_Manager.Areas.RPGArea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Areas.RPGArea.Data
{
    public class CharacterContext : DbContext
    {
        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options) { }

        public DbSet<Character> Character { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Campaign> Campaign { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Character>().ToTable("Character");
            mb.Entity<Account>().ToTable("Account");
            mb.Entity<Campaign>().ToTable("Campaign");
        }
    }
}
