using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLib
{
    /// <summary>
    /// Libraray for Race data.
    /// </summary>
    public class Races
    {
        
        //update this number after adding a new chareacter class
        private static int _numberOfIncludedRaces = 9;
        private int[][] _races = new int[_numberOfIncludedRaces][];

        /// <summary>Returns a read only int array of Hit Point modifers in alphabetical order</summary>
        protected int[] RacialskillMod = new int[22];
        /// <summary>Stores character's Racial AC bonus</summary>
        protected int RacialACBonus { get; set; }
        /// <summary>Returns a read only int array of Hit Point modifers in alphabetical order</summary>
        public readonly int[] raceHPMod = { 4, 4, 4, 4, 4, 6, 6, 2, 4 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public readonly int[] androidMods = { -2, 0, 2, 2, 0, 0 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public readonly int[] humanMods = { 0, 0, 0, 0, 0, 0 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public readonly int[] kasathaMods = { 0, 0, 0, -2, 2, 2 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public readonly int[] lashuntaDMods = { 2, -2, 0, 2, 0, 0 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public readonly int[] lashuntaKMods = { 2, 0, 0, 0, 2, -2 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public readonly int[] shirrenMods = { -2, 2, 0, 0, 0, 2 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public readonly int[] veskMods = { 0, 2, 0, -2, 2, 0 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public readonly int[] YoskiMods = { 0, 0, 2, 2, -2, 0 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public readonly int[] otherRaceMods = { 0, 0, 0, 0, 0, 0 };
        /// <summary>Returns a read onlystring array of race names</summary>
        public readonly string[] raceNames = { "Android", "Human", "Kasatha", "Lashunta[Damaya]",
            "Lashunta[Korasha]", "Shirren", "Vesk", "Yoski", "other" };

        
        /// <summary>Store Race Ability Score Adjustments [0-5] in Alphbetical order, Parrallel with Ability scores</summary>
        protected int[] _racialAbilityScoreAdjustment = { 0, 0, 0, 0, 0, 0 };

        /// <summary>Stores Racial Ability Score Adjustments in alphabetical order</summary>
        public int[] RacialAbilityScoreAdjustment
        {
            get
            {
                return _racialAbilityScoreAdjustment;
            }
            set
            {
                _racialAbilityScoreAdjustment = value;
            }
        }

        /// <summary>
        /// Returns an array if ints, each corresponding to skill IDs that gain racial bonuses
        /// Returns -1 if there is no skill bonus and 99 to pick any.
        /// </summary>
        /// <param name="raceID">Race ID corrisponding to Races in alphbetical order</param>
        /// <returns>int array or null</returns>
        public int[] RacialBonusSkills(int raceID)
        {
            int[] bonusSkills;
            switch (raceID)
            {
                case 0:
                    //Android
                    bonusSkills = new int[] { -1, -1, -1 };
                    //{none, none, none}
                    break;
                case 1:
                    //Human
                    bonusSkills = new int[] { -1, -1, -1 };
                    //{none, none, none}
                    break;
                case 2:
                    //Kasatha
                    bonusSkills = new int[] { 0, 4, 1};
                    //{Acrobatics, Culture, Athletics}
                    break;
                case 3:
                    //Lashunta[Damaya]
                    bonusSkills = new int[] { 99, -1, 99};
                    //{any, none, any}
                    break;
                case 4:
                    //Lashunta[Korasha]
                    bonusSkills = new int[] { 99, -1, 99 };
                    //{any, none, any}
                    break;
                case 5:
                    //Shirren
                    bonusSkills = new int[] { 4, -1, 5 };
                    //{ Culture, none, Diplomacy}
                    break;
                case 6:
                    //Vesk
                    bonusSkills = new int[] { -1, -1, -1 };
                    //{none, none, none}
                    break;
                case 7:
                    //Yoski
                    bonusSkills = new int[] { 7, 18, 19 };
                    //{Engineering, Survival, Stealth}
                    break;
                case 8:
                    //Other
                    bonusSkills = new int[] { 99, -1, 99 };
                    //{any, none, any}
                    break;
                default:
                    bonusSkills = new int[] { -1, -1, -1 };
                    //{none, none, none}
                    break;
            }
            return bonusSkills;
        }

        /// <summary>Returns a read only String of a race name.</summary>
        public string getRaceName(int raceID)
        {
            return raceNames[raceID];
        }

        /// <summary>Returns a 2D array contiaing Ability Score modifiers</summary>
        public int[][] RaceMods
        {
            get
            {
                _races[0] = androidMods;
                _races[1] = humanMods;
                _races[2] = kasathaMods;
                _races[3] = lashuntaDMods;
                _races[4] = lashuntaKMods;
                _races[5] = shirrenMods;
                _races[6] = veskMods;
                _races[7] = YoskiMods;
                _races[8] = otherRaceMods;
                return _races;
            }
        }

        /// <summary>
        /// Returns an array contiaing Race Ability Score modifiers
        /// </summary>
        /// <param name="classId">Int of 0-8</param>
        /// <returns>Array of int</returns>
        public int[] getClassArray(int classId)//race stat mods
        {
            _races[0] = androidMods;
            _races[1] = humanMods;
            _races[2] = kasathaMods;
            _races[3] = lashuntaDMods;
            _races[4] = lashuntaKMods;
            _races[5] = shirrenMods;
            _races[6] = veskMods;
            _races[7] = YoskiMods;
            _races[8] = otherRaceMods;
            return _races[classId];
        }    
    }//end class
}//end namespace
