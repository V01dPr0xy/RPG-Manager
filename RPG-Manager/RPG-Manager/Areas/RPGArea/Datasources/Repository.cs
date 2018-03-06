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

        public void AddAccount(Account a)
        {
            CC.Account.Add(a);
            CC.SaveChanges();
        }

        public void AddCampaign(Campaign c)
        {
            CC.Campaign.Add(c);
            CC.SaveChanges();
        }

        public void AddCharacter(Character c)
        {
            CC.Character.Add(c);
            CC.SaveChanges();
        }

        public void DeleteAccount(int AccountID)
        {
            foreach (var a in CC.Account)
                if (a.Account_ID == AccountID)
                    CC.Account.Remove(a);
            CC.SaveChanges();
        }

        public void DeleteCampaign(int CampaignID)
        {
            foreach (var c in CC.Campaign)
                if (c.Campaign_ID == CampaignID)
                    CC.Campaign.Remove(c);
            CC.SaveChanges();
        }

        public void DeleteCharacter(int ID)
        {
            foreach (var c in CC.Character)
                if (c.ID == ID)
                    CC.Character.Remove(c);
            CC.SaveChanges();
        }

        public void EditAccount(Account a)
        {
            CC.Account.Update(a);
            CC.SaveChanges();
        }

        public void EditCampaign(Campaign c)
        {
            CC.Campaign.Update(c);
            CC.SaveChanges();
        }

        public void EditCharacter(Character c)
        {
            CC.Character.Update(c);
            CC.SaveChanges();
        }

        public Account GetAccount(int AccountID)
        {
            return CC.Account.Single(a => a.Account_ID == AccountID);
        }

        public async Task<Account> GetAccountAsync(int AccountID)
        {
            return await CC.Account.SingleAsync(a => a.Account_ID == AccountID);
        }

        public Campaign GetCampaign(int CampaignID)
        {
            return CC.Campaign.Single(c => c.Campaign_ID == CampaignID);
        }

        public async Task<Campaign> GetCampaignAsync(int CampaignID)
        {
            return await CC.Campaign.SingleAsync(c => c.Campaign_ID == CampaignID);
        }

        public Character GetCharacter(int CharacterID)
        {
            return CC.Character.Single(c => c.ID == CharacterID);
        }

        public async Task<Character> GetCharacterAsync(int CharacterID)
        {
            return await CC.Character.SingleAsync(c => c.ID == CharacterID);
        }

        public async Task<List<Account>> List_Account()
        {
            return await CC.Account.ToListAsync();
        }

        public async Task<List<Campaign>> List_Campaign()
        {
            return await CC.Campaign.ToListAsync();
        }

        public async Task<List<Character>> List_Character()
        {
            return await CC.Character.ToListAsync();
        }
    }
}
