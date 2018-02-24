using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Areas.RPGArea.Models
{
    public class Character
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CharacterID { get; set; }


        public Character() { }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int Level { get; set; }
        [Required]
        [StringLength(50)]
        public string Class { get; set; }
        [Required]
        [StringLength(50)]
        public string Background { get; set; }
        [Required]
        [StringLength(50)]
        public string PlayerName { get; set; }
        [Required]
        [StringLength(50)]
        public string Race { get; set; }
        [Required]
        [StringLength(50)]
        public string Alignment { get; set; }
        [Required]
        public int XP { get; set; }

        [Required]
        public int STR { get; set; }
        [Required]
        public int DEX { get; set; }
        [Required]
        public int CON { get; set; }
        [Required]
        public int INT { get; set; }
        [Required]
        public int WIS { get; set; }
        [Required]
        public int CHA { get; set; }

        public bool Inspiration { get; set; }
        public int ProficiencyBonus { get; set; }

        public SavingThrows SavingThrow { get; set; }
        public Skills Skill { get; set; }

        [Required]
        public int ArmorClass { get; set; }
        [Required]
        public int Initiative { get; set; }
        [Required]
        public int Speed { get; set; }
        [Required]
        public int HitPointsMax { get; set; }
        [Required]
        public int HitPointsCurrent { get; set; }
        public int HitPointsTemporary { get; set; }
        [Required]
        public HitDice HitDie { get; set; }
        [Required]
        public string HitDice { get; set; }
        public int DeathSaves_Successes { get; set; }
        public int DeathSaves_Failures { get; set; }

        public ICollection<Action> Attacks { get; set; }
        public ICollection<Action> SpellCastings { get; set; }

        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }

        public string Features{ get; set; }
        public string Traits { get; set; }

        //public ICollection<string> Cantrips { get; set; }

        public ICollection<Spell> SpellsKnown { get; set; }

        [Required]
        public int Age { get; set; }
        [Required]
        public Height Height { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public string EyeColor { get; set; }
        [Required]
        public string Skin { get; set; }
        [Required]
        public string Hair { get; set; }
        public string Appearance { get; set; }
        //public ICollection<string> Allies{ get; set; }
        //public ICollection<string> Organizations { get; set; }
        public string Backstory { get; set; }
        public ICollection<Equipment> Treasure { get; set; }

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

    public class ValueType
    {
        public int Value_CopperPiece { get; set; }
        public int Value_SilverPiece { get; set; }
        public int Value_ElectrumPiece { get; set; }
        public int Value_GoldPiece { get; set; }
        public int Value_PlatinumPiece { get; set; }
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
        public string Name { get; set; }
        public ValueType VT { get; set; }
        public int Weight { get; set; }
        public string Notes  { get; set; }

    }

    public class Armor : Equipment
    {
        public int Resistance { get; set; }
        public bool ACModifiesDex { get; set; }
        public int ArmorClass { get; set; }
        public bool IsStealthDisadvantage { get; set; }
        public TimeSpan Don { get; set; }
        public TimeSpan Doff { get; set; }
    }

    public class Weapon : Equipment
    {

        public Damage Dmg { get; set; }
        public ICollection<string> Properties { get; set; }
    }    

    public class Damage
    {
        public HitDice MaxDmgRoll { get; set; }
        public DamageTypes DamageType { get; set; }
    }

    public enum DamageTypes
    {
        BLUDGEONING,
        PIERCING,
        SLASHING
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
}
