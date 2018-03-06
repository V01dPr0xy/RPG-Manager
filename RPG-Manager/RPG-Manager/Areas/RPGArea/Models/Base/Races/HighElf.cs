using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Models.Races
{
    public class HighElf
    {
        public int strengthAdjustment = 0;
        public int dexterityAdjustment = 2;
        public int constitutionAdjustment = 0;
        public int intelligenceAdjustment = 1;
        public int wisdomAdjustment = 0;
        public int charismaAdjustment = 0;

        public string ReturnFeatures()
        {
            return "Darkvision. Accustomed to twilit forests and the night sky, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can’t discern color in darkness, only shades of gray." + "\nKeen Senses. You have proficiency in the Perception skill. Fey Ancestry. You have advantage on saving throws against being charmed, and magic can’t put you to sleep." +
                   "\nTrance.Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams are actually mental exercises that have becom e reflexive through years of practice.After resting in this way, you gain the same benefit that a human does from 8 hours of sleep." + "\nElf Weapon Training. You have proficiency with the longsword, shortsword, shortbow, and longbow." +
                   "\nCantrip.You know one cantrip of your choice from the wizard spell list. Intelligence is your spellcasting ability for it.";
        }

        public int ReturnSpeed()
        {
            return 30;
        }

        public string ReturnLanguages()
        {
            return "Languages. You can speak, read, and write Common and Elvish. Elvish is fluid, with subtle intonations and intricate grammar. Elven literature is rich and varied, and their songs and poems are famous among other races. Many bards learn their language so they can add Elvish ballads to their repertoires. In addition, high elves can speak, read, and write one additional language of their choice.";
        }
    }
}
