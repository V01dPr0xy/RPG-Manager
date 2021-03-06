﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Models.Races
{
    public class Dragonborn
    {
        public int strengthAdjustment = 2;
        public int dexterityAdjustment = 0;
        public int constitutionAdjustment = 0;
        public int intelligenceAdjustment = 0;
        public int wisdomAdjustment = 0;
        public int charismaAdjustment = 1;

        public string ReturnFeatures()
        {
            return "Draconic Ancestry. You have draconic ancestry. Choose one type of dragon from the Draconic Ancestry table. Your breath weapon and damage resistance are determined by the dragon type, as shown in the table." + "\nBreath Weapon. You can use your action to exhale destructive energy. Your draconic ancestry determines the size, shape, and damage type of the exhalation. When you use your breath weapon, each creature in the area of the exhalation must make a saving throw, the type of which is determined by your draconic ancestry. The DC for this saving throw equals 8 + your Constitution modifier + your proficiency bonus. A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increases to 3d6 at 6th level, 4d6 at 11th level, and 5d6 at 16th level. After you use your breath weapon, you can’t use it again until you complete a short or long rest." + "\nDamage Resistance. You have resistance to the damage type associated with your draconic ancestry.";
        }

        public int ReturnSpeed()
        {
            return 30;
        }

        public string ReturnLanguages()
        {
            return "You can speak, read, and write Common and Draconic. Draconic is thought to be one of the oldest languages and is often used in the study of magic. The language sounds harsh to most other creatures and includes numerous hard consonants and sibilants.";
        }
    }
}
