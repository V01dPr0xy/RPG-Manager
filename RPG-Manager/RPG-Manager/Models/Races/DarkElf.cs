using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Models.Races
{
    public class DarkElf
    {
        public int strengthAdjustment = 0;
        public int dexterityAdjustment = 2;
        public int constitutionAdjustment = 0;
        public int intelligenceAdjustment = 0;
        public int wisdomAdjustment = 0;
        public int charismaAdjustment = 1;

        public string ReturnFeatures()
        {
            return "Keen Senses. You have proficiency in the Perception skill. Fey Ancestry. You have advantage on saving throws against being charmed, and magic can’t put you to sleep." +
                   "\nTrance.Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams are actually mental exercises that have becom e reflexive through years of practice.After resting in this way, you gain the same benefit that a human does from 8 hours of sleep." +
                   "\nSuperior Darkvision. Your darkvision has a radius of 120 feet." + "\nSunlight Sensitivity. You have disadvantage on attack rolls and on Wisdom (Perception) checks that rely on sight when you, the target of your attack, or whatever you are trying to perceive is in direct sunlight." + "\nDrow Magic. You know the dancing lights cantrip. When you reach 3rd level, you can cast the faerie fire spell once per day. When you reach 5th level, you can also cast the darkness spell once per day. Charisma is your spellcasting ability for these spells." + "\nDrow Weapon Training. You have proficiency with rapiers, shortswords, and hand crossbows.";
        }

        public int ReturnSpeed()
        {
            return 30;
        }

        public string ReturnLanguages()
        {
            return "Languages. You can speak, read, and write Common and Elvish. Elvish is fluid, with subtle intonations and intricate grammar. Elven literature is rich and varied, and their songs and poems are famous among other races. Many bards learn their language so they can add Elvish ballads to their repertoires.";
        }
    }
}
