using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RPG_Manager.Areas.RPGArea.Data;
using RPG_Manager.Areas.RPGArea.Models;

namespace RPG_Manager.Areas.RPGArea.Datasources
{
    public class Repository : IRepository
    {
        private readonly CharacterContext CC;

        public Repository(CharacterContext cC)
        {
            CC = cC;
        }

        public void AddCharacter(Character c)
        {
            CC.Character.Add(c);
            CC.SaveChanges();
        }

        public void DeleteCharacter(int ID)
        {
            foreach (var c in CC.Character)
                if (c.CharacterID == ID)
                    CC.Character.Remove(c);
            CC.SaveChanges();
        }

        public void EditCharacter(Character c)
        {
            CC.Character.Update(c);
            CC.SaveChanges();
        }

        public async Task<Character> GetCharacter(int CharacterID)
        {
            return await CC.Character.SingleAsync(c => c.CharacterID == CharacterID);
        }

        public async Task<List<Character>> List_Character()
        {
            return await CC.Character.ToListAsync();
        }
    }
}
