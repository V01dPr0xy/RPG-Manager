using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Areas.RPGArea.Models
{
    public class Character
    {
        public Character() { }

        public string Name { get; set; }
        public int Level { get; set; }
        public string Class { get; set; }
        public string Background { get; set; }
        public string PlayerName { get; set; }
        public string Race { get; set; }
        public string Alignment { get; set; }
        public int Experience_Points { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public bool Inspiration { get; set; }
        public int ProficiencyBonus { get; set; }

        public SavingThrows SavingThrow { get; set; }
        public Skills Skill { get; set; }

        public int ArmorClass { get; set; }
        public int Initiative { get; set; }
        public int Speed { get; set; }
        public int HitPointsMax { get; set; }
        public int HitPointsCurrent { get; set; }
        public int HitPointsTemporary { get; set; }
        public string TotalHitDie { get; set; }
        public string HitDice { get; set; }
        public int DeathSaves_Successes { get; set; }
        public int DeathSaves_Failures { get; set; }

        public List<Action> Attacks{ get; set; }
        public List<Action> SpellCastings { get; set; }

        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }

        public string Features{ get; set; }
        public string Traits { get; set; }

        public List<string> Cantrips { get; set; }

        public List<Spell> SpellsKnown { get; set; }

        public int Age { get; set; }
        public Height Height { get; set; }
        public int Weight { get; set; }
        public string EyeColor { get; set; }
        public string Skin { get; set; }
        public string Hair { get; set; }
        public string Appearance { get; set; }
        public List<string> Allies{ get; set; }
        public List<string> Organizations { get; set; }
        public string Backstory { get; set; }
        public List<Item> Treasure { get; set; }



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
    }

    public class SpellCasting : Action
    {
        public int Damage { get; set; }
        public int Level { get; set; }
    }

    public class Attack : Action
    {
        public string Type { get; set; }
    }

    public class Action
    {
        public string Name { get; set; }
        public int AttackBonus { get; set; }
    }

    public class Equipment
    {
        public int CopperPiece { get; set; }
        public int SilverPiece { get; set; }
        public int ElectrumPiece { get; set; }
        public int GoldPiece { get; set; }
        public int PlatinumPiece { get; set; }

        public int ArmorClass { get; set; }
    }

    public class Spell
    {
        public int Level { get; set; }
        public int SlotsTotal { get; set; }
        public int SlotsExpended { get; set; }
        public string Description { get; set; }
    }

    public class Height
    {
        public int Feet { get; set; }
        public int Inches { get; set; }
    }
    
    public class Item
    {

    }
}
