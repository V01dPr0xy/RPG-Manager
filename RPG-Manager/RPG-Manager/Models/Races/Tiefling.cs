using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Models.Races
{
    public class Tiefling
    {
        public int strengthAdjustment = 0;
        public int dexterityAdjustment = 0;
        public int constitutionAdjustment = 0;
        public int intelligenceAdjustment = 1;
        public int wisdomAdjustment = 0;
        public int charismaAdjustment = 2;

        public string ReturnFeatures()
        {
            return "Darkvision. Thanks to your elf blood, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." + "\nHellish Resistance. You have resistance to fire damage." + "\nInfernal Legacy. You know the thaumaturgy cantrip. Once you reach 3rd level, you can cast the hellish rebuke spell once per day as a 2nd-level spell. Once you reach 5th level, you can also cast the darkness spell once per day. Charisma is your spellcasting ability for these spells.";
        }

        public int ReturnSpeed()
        {
            return 30;
        }

        public string ReturnLanguages()
        {
            return "You can speak, read, and write Common and Infernal.";
        }
    }
}
