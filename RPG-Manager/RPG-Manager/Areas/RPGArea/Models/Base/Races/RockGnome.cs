using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Models.Races
{
    public class RockGnome
    {
        public int strengthAdjustment = 0;
        public int dexterityAdjustment = 0;
        public int constitutionAdjustment = 1;
        public int intelligenceAdjustment = 2;
        public int wisdomAdjustment = 0;
        public int charismaAdjustment = 0;

        public string ReturnFeatures()
        {
            return "Darkvision. Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray." + "\nGnome Cunning. You have advantage on all Intelligence, Wisdom, and Charisma saving throws against magic." +
                   "\nArtificer’s Lore. Whenever you make an Intelligence (History) check related to magic items, alchemical objects, or technological devices, you can add twice your proficiency bonus, instead of any proficiency bonus you normally apply." + "\n Tinker. You have proficiency with artisan’s tools (tinker’s tools). Using those tools, you can spend 1 hour and 10 gp worth of materials to construct a Tiny clockwork device (AC 5, 1 hp). The device ceases to function after 24 hours (unless you spend 1 hour repairing it to keep the device functioning), or when you use your action to dismantle it; at that time, you can reclaim the materials used to create it. You can have up to three such devices active at a time. When you create a device, choose one of the following options:" +
                   "\nClockwork Toy. This toy is a clockwork animal, monster, or person, such as a frog, mouse, bird, dragon, or soldier. When placed on the ground, the toy moves 5 feet across the ground on each of your turns in a random direction.It makes noises as appropriate to the creature it represents." + "\nFire Starter. The device produces a miniature flame, which you can use to light a candle, torch, or campfire. Using the device requires your action. Music Box. When opened, this music box plays a single song at a moderate volume. The box stops playing when it reaches the song’s end or when it is closed.";
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
