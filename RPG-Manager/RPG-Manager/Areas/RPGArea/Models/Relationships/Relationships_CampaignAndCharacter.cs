using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RPG_Manager.Areas.RPGArea.Models.Base.StueckClassesContainer;

namespace RPG_Manager.Areas.RPGArea.Models.Relationships
{
    public class Relationships_CampaignAndCharacter : ClassIDGen
    {
        public int CampaignID { get; set; }
        public Campaign Campaign { get; set; }

        public int CharacterID { get; set; }
        public Character Character { get; set; }
    }
}
