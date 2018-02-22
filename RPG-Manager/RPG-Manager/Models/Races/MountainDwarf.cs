using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Models.Races
{
    public class MountainDwarf
    {
        public int strengthAdjustment = 2;
        public int dexterityAdjustment = 0;
        public int constitutionAdjustment = 2;
        public int intelligenceAdjustment = 0;
        public int wisdomAdjustment = 0;
        public int charismaAdjustment = 0;

        public string ReturnFeatures()
        {
            return "Darkvision. Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." + "\nDwarven Resilience. You have advantage on saving throws against poison, and you have resistance against poison damage (explained in chapter 9). Dwarven Combat Training. You have proficiency with the battleaxe, handaxe, throwing hammer, and warhammer." +
                    "\nTool Proficiency. You gain proficiency with the artisan’s tools of your choice: smith’s tools, brewer’s supplies, or mason’s tools." + "\nStonecunning.Whenever you make an Intelligence(History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus." +
                    "\nDwarven Armor Training. You have proficiency with light and medium armor.";
        }

        public int ReturnSpeed()
        {
            return 25;
        }

        public string ReturnLanguages()
        {
            return "You can speak, read, and write Common and Dwarvish. Dwarvish is full of hard consonants and guttural sounds, and those characteristics spill over into whatever other language a dwarf might speak.";
        }
    }
}
