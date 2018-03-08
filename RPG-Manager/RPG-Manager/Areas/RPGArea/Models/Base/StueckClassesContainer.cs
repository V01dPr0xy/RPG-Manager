using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static RPG_Manager.Areas.RPGArea.Models.Base.Enums;

namespace RPG_Manager.Areas.RPGArea.Models.Base
{
    public class StueckClassesContainer
    {
        public class TurnAction : ClassIDGen
        {
            public string Name { get; set; }
            public int AttackBonus { get; set; }
        }
        public class Ally : ICollectionObj { }
        public class Armor : Equipment
        {
            public int Resistance { get; set; }
            public bool ACModifiesDex { get; set; }
            public int ArmorClass { get; set; }
            public bool IsStealthDisadvantage { get; set; }
            public TimeSpan Don { get; set; }
            public TimeSpan Doff { get; set; }
        }
        public class Attack : TurnAction
        {
            public string Type { get; set; }
        }
        public class Cantrip : ICollectionObj { }
        public class ClassIDGen
        {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key]
            public int ID { get; set; }
        }
        public class Damage : ClassIDGen
        {
            public HitDice MaxDmgRoll { get; set; }
            public DamageTypes DamageType { get; set; }
        }
        public class Equipment : ClassIDGen
        {
            public string Name { get; set; }
            public ValueType VT { get; set; }
            public int Weight { get; set; }
            public string Notes { get; set; }

        }
        public class Height : ClassIDGen
        {
            public int Feet { get; set; }
            public int Inches { get; set; }
        }
        public class ICollectionObj : ClassIDGen
        {
            public string Text { get; set; }
        }
        public class Organization : ICollectionObj { }
        public class Spell : ClassIDGen
        {
            public int Level { get; set; }
            public int SlotsTotal { get; set; }
            public int SlotsExpended { get; set; }
            public string Description { get; set; }
        }
        public class SpellCasting : TurnAction
        {
            public int Damage { get; set; }
            public int Level { get; set; }
        }
        public class Weapon : Equipment
        {

            public Damage Dmg { get; set; }
            public ICollection<string> Properties { get; set; }
        }
        public class ValueType : ClassIDGen
        {
            public int Value_CopperPiece { get; set; }
            public int Value_SilverPiece { get; set; }
            public int Value_ElectrumPiece { get; set; }
            public int Value_GoldPiece { get; set; }
            public int Value_PlatinumPiece { get; set; }
        }
    }
}
