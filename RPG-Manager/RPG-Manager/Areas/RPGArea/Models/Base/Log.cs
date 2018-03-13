using RPG_Manager.Areas.RPGArea.Models.Authorizational_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RPG_Manager.Areas.RPGArea.Models.Base.StueckClassesContainer;

namespace RPG_Manager.Areas.RPGArea.Models.Base
{
    public class Log : ClassIDGen
    {
        public Register Account { get; set; }
        public string MessageLog { get; set; }
        public DateTime TimeOfMessage { get; set; }
    }
}
