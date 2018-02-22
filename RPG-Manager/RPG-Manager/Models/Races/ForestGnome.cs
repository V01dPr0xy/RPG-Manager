using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Models.Races
{
    public class ForestGnome
    {
        public int strengthAdjustment = 0;
        public int dexterityAdjustment = 0;
        public int constitutionAdjustment = 0;
        public int intelligenceAdjustment = 2;
        public int wisdomAdjustment = 0;
        public int charismaAdjustment = 0;

        public string ReturnFeatures()
        {
            return "Darkvision. Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray." + "\nGnome Cunning. You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic." +
                   "\nNatural Illusionist. You know the minor illusion cantrip. Intelligence is your spellcasting ability for it." + "\nSpeak with Small Beasts. Through sounds and gestures, you can communicate simple ideas with Small or smaller beasts. Forest gnomes love animals and often keep squirrels, badgers, rabbits, moles, woodpeckers, and other creatures as beloved pets.";
        }

        public int ReturnSpeed()
        {
            return 25;
        }

        public string ReturnLanguages()
        {
            return "You can speak, read, and write Common and Gnomish. The Gnomish language, which uses the Dwarvish script, is renowned for its technical treatises and its catalogs of knowledge about the natural world.";
        }
    }
}
