using RPG_Manager.Areas.RPGArea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Areas.RPGArea
{
    public interface IRepository
    {
        Task<Character> GetCharacter(int CharacterID);
        void AddCharacter(Character c);
        void EditCharacter(Character c);
        void DeleteCharacter(int ID);
        Task<List<Character>> List_Character();
    }
}
