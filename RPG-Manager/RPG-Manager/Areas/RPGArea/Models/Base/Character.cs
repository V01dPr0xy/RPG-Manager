using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static RPG_Manager.Areas.RPGArea.Models.Base.Enums;
using static RPG_Manager.Areas.RPGArea.Models.Base.StueckClassesContainer;

namespace RPG_Manager.Areas.RPGArea.Models
{
    public class Character : ClassIDGen 
    {
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

        public ICollection<TurnAction> Attacks { get; set; }
        public ICollection<TurnAction> SpellCastings { get; set; }

        public string PersonalityTraits { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }

        public string Features { get; set; }
        public string Traits { get; set; }

        public ICollection<Cantrip> Cantrips { get; set; }

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
        public ICollection<Ally> Allies { get; set; }
        public ICollection<Organization> Organizations { get; set; }
        public string Backstory { get; set; }
        public ICollection<Equipment> Treasure { get; set; }
    }
}
