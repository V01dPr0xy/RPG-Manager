using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Areas.RPGArea.Models
{
    public class Campaign
    {
        public int Campaign_ID { get; set; }
        public Account DungeonMaster { get; set; }
        public Dictionary<Account, Character> Characters { get; set; }
        public Dictionary<Account, string> Log { get; set; }
        public int Turns { get; set; }
    }
}
