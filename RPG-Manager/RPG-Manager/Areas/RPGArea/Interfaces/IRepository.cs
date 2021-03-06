﻿using RPG_Manager.Areas.RPGArea.Models;
using RPG_Manager.Areas.RPGArea.Models.Authorizational_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Areas.RPGArea
{
    public interface IRepository
    {
        Task<Character> GetCharacterAsync(int CharacterID);
        Character GetCharacter(int CharacterID);
        void AddCharacter(Character c);
        void EditCharacter(Character c);
        void DeleteCharacter(int ID);
        Task<List<Character>> List_Character();

        Task<Register> GetAccountAsync(int AccountID);
        Register GetAccount(int AccountID);
        void AddAccount(Register a);
        void EditAccount(Register a);
        void DeleteAccount(int AccountID);
        Task<List<Register>> List_Account();

        Task<Campaign> GetCampaignAsync(int CampaignID);
        Campaign GetCampaign(int CampaignID);
        void AddCampaign(Campaign c);
        void EditCampaign(Campaign c);
        void DeleteCampaign(int CampaignID);
        Task<List<Campaign>> List_Campaign();
    }
}
