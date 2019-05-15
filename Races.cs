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
        private static int _numberOfIncludedRaces = 9;
        private int[][] _races = new int[_numberOfIncludedRaces][];
        private bool[] _isRacialClassSkill = new bool[20];
        private static string[] _raceNames = { "Android", "Human", "Kasatha", "Lashunta [Damaya]",
            "Lashunta [Korasha]", "Shirren", "Vesk", "Yoski", "other" };


        /// <summary>
        /// stores an array of Racial skills that count as class skills
        /// each one corrisponds to the index value of a character skill
        /// </summary>
        public int[] RacialClassSkillIndexes { get; set; } = { -1, -1, -1 }; //defualt should translate to none.

        /// <summary>Holds the index value for the character's race.</summary>
        public int CharacterRaceId { set; get; } = -1; //0-7.

        /// <summary>Holds the character's racial HP modifier</summary>
        public int RaceHPMod
        {
            get
            {
                //check to see if a race has been chosen
                if(CharacterRaceId != -1)
                {
                    //return the race specific HP mod
                    return RaceHPMods[CharacterRaceId];
                }
                else
                {
                    //retrun a negative
                    //check for this in aplication.
                    return -1;
                }
            }
        }

        /// <summary>Stores Players chosen race name string</summary>
        public string RaceName{ get; set; } = "None Selected";
        /// <summary>Stores character's Racial AC bonus</summary>
        public int RacialACBonus { get; set; } = 0;
        /// <summary>Returns a read only int array of Hit Point modifers relative to Core Races alphabetical order</summary>
        public int[] RaceHPMods { get; } = { 4, 4, 4, 4, 4, 6, 6, 2, 4 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public int[] AndroidMods { get; } = { -2, 0, 2, 2, 0, 0 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public int[] HumanMods { get; } = { 0, 0, 0, 0, 0, 0 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public int[] KasathaMods { get; } = { 0, 0, 0, -2, 2, 2 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public int[] LashuntaDMods { get; } = { 2, -2, 0, 2, 0, 0 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public int[] LashuntaKMods { get; } = { 2, 0, 0, 0, 2, -2 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public int[] ShirrenMods { get; } = { -2, 2, 0, 0, 0, 2 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public int[] VeskMods { get; } = { 0, 2, 0, -2, 2, 0 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public int[] YoskiMods { get; } = { 0, 0, 2, 2, -2, 0 };
        /// <summary>Returns a read only int array of Ability Score modifers in alphabetical order</summary>
        public int[] OtherRaceMods { get; } = { 0, 0, 0, 0, 0, 0 };
        /// <summary>Stores Racial Ability Score Adjustments in alphabetical order</summary>
        public int[] RacialAbilityScoreAdjustment { get; set; } = { 0, 0, 0, 0, 0, 0 };
        /// <summary>stores the index of the chosen ability score buff.</summary>
        public int OtherRaceChosenAbilityscore { get; set; } = -1;
        /// <summary>Player chose to manually set ability score adjustments</summary>
        public bool RaceUsesGodMode { get; set; } = false;
        /// <summary>
        /// Returns an array if ints, each corresponding to skill IDs that gain racial bonuses
        /// Returns -1 if there is no skill bonus and 99 to pick any.
        /// </summary>
        /// <param name="raceID">Race ID corrisponding to Races in alphbetical order</param>
        /// <returns>int array or null</returns>
        public int[] GetsRacialClassSkills(int raceID)
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

        /// <summary>Returns a read only array of a race name.</summary>
        public string[] RaceNames
        {
            get
            {
                return _raceNames;
            }
        }

        /// <summary>Returns a read only String of a race name.</summary>
        public string getRaceName(int raceID)
        {
            return _raceNames[raceID];
        }

        /// <summary>Returns a read only 2D array contiaing Ability Score modifiers</summary>
        public int[][] RaceMods
        {
            get
            {
                _races[0] = AndroidMods;
                _races[1] = HumanMods;
                _races[2] = KasathaMods;
                _races[3] = LashuntaDMods;
                _races[4] = LashuntaKMods;
                _races[5] = ShirrenMods;
                _races[6] = VeskMods;
                _races[7] = YoskiMods;
                _races[8] = OtherRaceMods;
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
            _races[0] = AndroidMods;
            _races[1] = HumanMods;
            _races[2] = KasathaMods;
            _races[3] = LashuntaDMods;
            _races[4] = LashuntaKMods;
            _races[5] = ShirrenMods;
            _races[6] = VeskMods;
            _races[7] = YoskiMods;
            _races[8] = OtherRaceMods;
            return _races[classId];
        }    
    }//end class
}//end namespace
