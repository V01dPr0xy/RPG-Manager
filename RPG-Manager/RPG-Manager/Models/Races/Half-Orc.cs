using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Models.Races
{
    public class Half_Orc
    {
        public int strengthAdjustment = 2;
        public int dexterityAdjustment = 0;
        public int constitutionAdjustment = 1;
        public int intelligenceAdjustment = 0;
        public int wisdomAdjustment = 0;
        public int charismaAdjustment = 0;

        public string ReturnFeatures()
        {
            return "Darkvision. Thanks to your orc blood, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray." + "\nMenacing. You gain proficiency in the Intimidation skill." + "\nRelentless Endurance. When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead. You can’t use this feature again until you finish a long rest." + "\nSavage Attacks. When you score a critical hit with a melee weapon attack, you can roll one of the weapon’s damage dice one additional time and add it to the extra damage of the critical hit.";
        }

        public int ReturnSpeed()
        {
            return 30;
        }

        public string ReturnLanguages()
        {
            return "You can speak, read, and write Common and Orc . Orc is a harsh, grating language with hard consonants. It has no script of its own but is written in the Dwarvish script.";
        }
    }
}
