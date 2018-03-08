using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RPG_Manager.Areas.RPGArea.Models.Base.StueckClassesContainer;

namespace RPG_Manager.Areas.RPGArea.Models
{
    public class HitDice : ClassIDGen
    {
        public HitDice(Dice diceType, int amount)
        {
            DiceType = diceType;
            Amount = amount;
        }

        public Dice DiceType { get; set; }
        public int Amount { get; set; }

        public static int operator +(HitDice hd, int CONMOD)
        {
            return ((int)hd.DiceType * hd.Amount) + CONMOD;
        }
    }

    public enum Dice
    {
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D10 = 10,
        D12 = 12,
        D20 = 20
    }
}
