using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Models.Races
{
    public class Half_Elf
    {
        public int strengthAdjustment = 0;
        public int dexterityAdjustment = 0;
        public int constitutionAdjustment = 0;
        public int intelligenceAdjustment = 0;
        public int wisdomAdjustment = 0;
        public int charismaAdjustment = 2;

        public string ReturnFeatures()
        {
            return "Darkvision. Thanks to your elf blood, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." + "\nFey Ancestry. You have advantage on saving throws against being charmed, and magic can’t put you to sleep." + "\nSkill Versatility. You gain proficiency in two skills of your choice." + "\nYou also increase two other ability scores of your choice by 1.";
        }

        public int ReturnSpeed()
        {
            return 30;
        }

        public string ReturnLanguages()
        {
            return "You can speak, read, and write Common, Elvish, and one extra language of your choice.";
        }
    }
}
