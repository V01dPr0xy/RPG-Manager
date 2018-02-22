using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Manager.Models.Races
{
    public class StoutHalfling
    {
        public int strengthAdjustment = 0;
        public int dexterityAdjustment = 2;
        public int constitutionAdjustment = 1;
        public int intelligenceAdjustment = 0;
        public int wisdomAdjustment = 0;
        public int charismaAdjustment = 0;

        public string ReturnFeatures()
        {
            return "Lucky. W hen you roll a 1 on an attack roll, ability check, or saving throw, you can reroll the die and must use the new roll." + "\nBrave. You have advantage on saving throws against being frightened." + "\nHalfling Nimbleness. You can move through the space of any creature that is of a size larger than yours." +
                   "\nStout Resilience. You have advantage on saving throws against poison, and you have resistance against poison damage.";
        }

        public int ReturnSpeed()
        {
            return 25;
        }

        public string ReturnLanguages()
        {
            return "You can speak, read, and write Common and Halfling. The Halfling language isn’t secret, but halflings are loath to share it with others. They write very little, so they don’t have a rich body of literature. Their oral tradition, however, is very strong. Almost all halflings speak Common to converse with the people in whose lands they dwell or through which they are traveling.";
        }
    }
}
