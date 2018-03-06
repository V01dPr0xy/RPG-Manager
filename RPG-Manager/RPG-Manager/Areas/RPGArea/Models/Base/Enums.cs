using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Areas.RPGArea.Models.Base
{
    public class Enums
    {
        [Flags]
        public enum SavingThrows
        {
            STRENGTH,
            DEXTERITY,
            CONSTITUTION,
            INTELLIGENCE,
            WISDOM,
            CHARISMA
        }

        [Flags]
        public enum Skills
        {
            ACROBATICS,
            ANIMAL_HANDLING,
            ARCANA,
            ATHLETICS,
            DECEPTION,
            HISTORY,
            INSIGHT,
            INTIMIDATION,
            INVESTIGATION,
            MEDICINE,
            NATURE,
            PERCEPTION,
            PERFORMANCE,
            PERSUASION,
            RELIGION,
            SLEIGHTOFHAND,
            STEALTH,
            SURVIVAL
        }

        public enum DamageTypes
        {
            BLUDGEONING,
            PIERCING,
            SLASHING
        }
    }
}
