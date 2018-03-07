using RPG_Manager.Areas.RPGArea.Models.Authorizational_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RPG_Manager.Areas.RPGArea.Models.Base.StueckClassesContainer;

namespace RPG_Manager.Areas.RPGArea.Models.Relationships
{
    public class Relationship_CampaignAndAccount : ClassIDGen
    {
        public int CampaignID { get; set; }
        public Campaign Campaign { get; set; }

        public int AccountID { get; set; }
        public Register Account { get; set; }
    }
}
