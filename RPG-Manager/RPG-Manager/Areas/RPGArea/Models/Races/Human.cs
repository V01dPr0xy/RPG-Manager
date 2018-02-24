using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Models.Races
{
    public class Human
    {
        public int strengthAdjustment = 1;
        public int dexterityAdjustment = 1;
        public int constitutionAdjustment = 1;
        public int intelligenceAdjustment = 1;
        public int wisdomAdjustment = 1;
        public int charismaAdjustment = 1;

        public string ReturnFeatures()
        {
            return "None.";
        }

        public int ReturnSpeed()
        {
            return 30;
        }

        public string ReturnLanguages()
        {
            return "You can speak, read, and write Common and one extra language of your choice. Humans typically learn the languages of other peoples they deal with, including obscure dialects. They are fond of sprinkling their speech with words borrowed from other tongues: Orc curses, Elvish musical expressions, Dwarvish military phrases, and so on.";
        }
    }
}
