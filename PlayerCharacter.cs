﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLib
{
    /// <summary>
    /// This class stores charactor data for
    /// This is where finalized data should be stored.
    /// </summary>
    public class PlayerCharacter : Races
    {

        //unique data
        /// <summary>Charactor's Name</summary>
        public string CharacterName { set; get; } = "New Character";
        /// <summary>Player's Name</summary>
        public string PlayerName { set; get; } = "Your Name";
        /// <summary>Player's Short Concept Description</summary>
        public string Concept { set; get; } = "Who Is this person?";
        /// <summary>Player's Notes entered on Step 1</summary>
        public string Step1Notes { set; get; } = "Use this area to save notes about your Character";
        /// <summary>Player's Notes entered on Step 2/summary>
        public string Step2Notes { set; get; } = "";
        /// <summary>Player's longform notes and ideas(will dispaly on seperate page of final sheet)</summary>
        public string NotesAndIdeas {
            get
            {
                string _step1Notes;
                if (Step1Notes == "Use this area to save notes about your Character")
                {
                    _step1Notes = "";
                }
                else
                {
                    _step1Notes = Step1Notes;
                }
                string notes ="Step 1 Notes:" + cr() + _step1Notes + cr() + "Step 2 Notes:" + cr() + Step2Notes;
                return notes;
            }
        }
        private int playerLevel;//Property (Level) returns sum of classes 1 and 2
        private int playerBAB;
        private bool heavyArmor = false;//default is false
        /// <summary>Player's Diety or could also be self if you're just that awesome</summary>
        public string Deity { set; get; } = "The number 42";

        //Weapon stuff 
        private bool[] weaponProficiency = new bool[7];//basic melee[0], advanced melee[1], small arms[2], long arms[3], sniper[4], heavy[5], granades[6]
        private string[] proficiencies = { "Basic Melee Weapons", "Advanced Melee Weapons", "Small Arms", "Longarms", "Sniper Weapons", "heavy Weapons", "granades" };

        //ability score stuff
        private int[] _baseAbilityScores = { 10, 10, 10, 10, 10, 10 }; //parrallel with AttributeNames, ability Mods and AbilityBrief Base stats at toon creation.
        private int[] _baseAbilityMods = { 0, 0, 0, 0, 0, 0 };//staring value after stat roll but before any adjustments or corrections.
        /// <summary>String Array of Ability names full [0-5] in alphabetical order Parallel with Ability Score Arrays</summary>
        public readonly string[] AbilityNames = { "Charsima", "Constitution", "Dexterity", "Intelligence", "Strength", "Wisdom" };
        /// <summary>String Array of Ability names full [0-5]in alphabetical order Parallel with Ability Score Arrays</summary>
        public readonly string[] AbilityNamesBrief = { "Cha", "Con", "Dex", "Int", "Str", "Wis" }; //6, 3, 4, 2, 1, 5 as they appear on the official Characer sheet
        private int[] abilityScoresFinal = { 10, 10, 10, 10, 10, 10 };//as ability scores will apear on the final toon
        /// <summary>Read only. Base experience amounts per level[0-20] use unadjusted character level</summary>
        public readonly int[] curentXP = { 0, 0, 1300, 3300, 6000, 10000, 15000, 23000, 34000, 50000, 71000, 105000, 145000, 210000, 295000, 425000, 600000, 850000, 1200000, 1700000, 2400000 };
        /// <summary>Read only. Experience amounts needed for next level[0-20] use unadjusted current character level Parallel with curentXP</summary>
        public readonly int[] nextLevelXP = { 0, 1300, 3300, 6000, 10000, 15000, 23000, 34000, 50000, 71000, 105000, 145000, 210000, 295000, 425000, 600000, 850000, 1200000, 1700000, 2400000, 0 };
        /// <summary>Read only. Unadjusted feats per level reguardless of classes[0-20] use unadjusted character level</summary>
        public readonly int[] featsPerLevel = { 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10 };

        //Race stuff goes here
        /// <summary>Holds the index value for the character's race.</summary>
        public int CharacterRaceId { set; get; } = -1; //0-7.
        private string _raceName;
        

        public int RaceHPMod { set; get; }
        
        //Theme stuff 
        public int[] themeAblityScoreAdjustment = { 0, 0, 0, 0, 0, 0 };
        public bool[] isThemeClassSkill = new bool[22];//stored sepeatly from Class class skills for latter comparison.
        /// <summary>This stores the Character's ThemeId wich is used in the Theme class</summary>
        public int PlayerThemeId { set; get; }
        public string[] themeBenifits = new string[4];//strores an array of beifits based on the level of the character. 

        //class stuff
        public bool MultiClass { set; get; }
        public readonly string[] ClassNames = { "Envoy", "Mechanic", "Mystic", "Operative", "Solarian", "Soldier", "Technomancer" };
        public int ClassID1 { set; get; }
        public int ClassID2 { set; get; }//incase of multiclassing.
        public int Class1Level { set; get; }
        public int Class2Level { set; get; }//incase of multiclassing.
        public int Class1ConMod { set; get; }
        public int Class2ConMod { set; get; }
        public int Class1HPMod { set; get; }
        public int Class2HPMod { set; get; }
        public int BAB1 { set; get; }
        public int BAB2 { set; get; }
        private string[] class1Features = new string[21];
        private string[] class2Features = new string[21];//incase of multiclassing.
        public int[] MysticSpellsPerDay; //first is ignored [classlevel][number of spells per day per level]
        public int[] TechnoSpellsPerDay { get; set; } //first is ignored [number of spells per day per level]
        public int[] MysticSpellsknown { get; set; } //first is ignored [number of spells per day per level]
        public int[] TechnoSpellsknown { get; set; } //first is ignored [number of spells per day per level]
        private int[] mysticBonusSpells { get; set; } //first is ignored [number of spells per day per level]
        private int[] technoBonusSpells { get; set; } //first is ignored [number of spells per day per level]


        //Skills stuff
        private int[] skills = new int[22];//stores final skill level values
        private int[] skillranks = new int[22];//stores purchased skill ranks independant from the final values.
        public string[] skillNames = {"Acrobatics", "Athletics", "Bluff", "Computer",
            "Computers", "Culture", "Diplomacy", "Disguise", "Engineering", "Intimidate", "Life Science",
            "Medicine", "Mysticism", "Perception", "Physical Science", "Piloting", "Profession",
            "Sense Motive", "Sleight of Hand", "Stealth", "Survival", "" };
        private int class1SkillsperLevel;
        private int class2SkillsperLevel;
        //  1     2       3     4     5       6     7       8      9      10      11     12     13    14      15    16     17     18      19     20
        private bool[] isClassSkill = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        public int[] abilityUsedForSkill = { 2, 4, 0, 3, 3, 0, 0, 3, 0, 3, 3, 5, 5, 3, 2, -1, -1, 5, 2, 2, 5, -1 };//number is associated with its location in player attribute array
        public int[] unnamedSkillBounus = new int[22];
        public bool[] isTrainedOnlySkill = { false, false, false, true, true, false, false, true, false, true, true,
            true, false, true, false, true, true, false, true, false, false, false };


        //Abilites
        public List<string> abilityList = new List<string>();
        public List<string> FeatList = new List<string>();
        public int UnspentFeats { get; set; }
        public int UnspentComatFeats { get; set; }

        /// <summary>Stores Players Selected Race name.</summary>
        public string RaceName
        {
            get
            {
                //check to see if user has selected a race yet
                if (CharacterRaceId == -1)
                {
                    return "None Selceted";
                }
                else
                {
                    return _raceName;
                }
            }
            set
            {
                _raceName = value;
            }
        }

        /// <summary>Returns pre-calculated array of spells per level based on Wisdom Score</summary>
        public int[] MysticBonusSpells
        {
            get
            {
                mysticBonusSpells = calcualteBonusSpells(_baseAbilityScores[5]);
                return mysticBonusSpells;
            }
        }
        public int[] TechnoBonusSpells
        {
            get
            {
                technoBonusSpells = calcualteBonusSpells(_baseAbilityScores[3]);
                return technoBonusSpells;
            }
        }


        private int[] calcualteBonusSpells(int score)//use to calculate bonus spells per level
        {
            int[] a = { -1, -1, -1, -1, -1, -1 };
            if (score < 12)
            {
                a = new int[] { 0, 0, 0, 0, 0, 0 };
            }
            else if (score < 14)
            {
                a = new int[] { 1, 0, 0, 0, 0, 0 };
            }
            else if (score < 16)
            {
                a = new int[] { 1, 1, 0, 0, 0, 0 };
            }
            else if (score < 18)
            {
                a = new int[] { 1, 1, 1, 0, 0, 0 };
            }
            else if (score < 20)
            {
                a = new int[] { 1, 1, 1, 1, 0, 0 };
            }
            else if (score < 22)
            {
                a = new int[] { 2, 1, 1, 1, 1, 0 };
            }
            else if (score < 24)
            {
                a = new int[] { 2, 2, 1, 1, 1, 1 };
            }
            else if (score < 26)
            {
                a = new int[] { 2, 2, 2, 1, 1, 1 };
            }
            else if (score < 28)
            {
                a = new int[] { 2, 2, 2, 2, 1, 1 };
            }
            else if (score < 30)
            {
                a = new int[] { 3, 2, 2, 2, 2, 1 };
            }
            else if (score < 32)
            {
                a = new int[] { 3, 3, 2, 2, 2, 2 };
            }//end if

            return a;
        } // end Calcualte bonus Spells


        public bool HeavyArmor
        {
            get
            {
                return heavyArmor;
            }
            set// if one class gives access to heavy the others can't deny access
            {
                if (heavyArmor == true)
                {
                    heavyArmor = true;
                }
                else
                {
                    heavyArmor = value;
                }
            }
        }

        public bool[] profiencies
        {
            get
            {
                return weaponProficiency;
            }
            set
            {
                bool[] a = value;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == true)
                    {
                        weaponProficiency[i] = true;
                    }
                }
            }//end set
        }// end profiencies

        public string[] GetClass1Features
        {
            get
            {
                return class1Features;
            }
        }

        public string[] SetClass1Features
        {
            set
            {
                class1Features = value;
            }
        }

        public string[] GetClass2Features
        {
            get
            {
                return class2Features;
            }
        }

        public string[] SetClass2Features
        {
            set
            {
                class2Features = value;
            }
        }

        public int Class1SkillsPerLevel
        {
            set
            {
                class1SkillsperLevel = value;
            }
            get
            {
                return 0;
            }
        }

        public int Class2SkillsPerLevel
        {
            set
            {
                class2SkillsperLevel = value;
            }
        }

        public int skillPoints
        {
            get
            {
                return (Class2Level * (class2SkillsperLevel + _baseAbilityMods[3])) + (Class1Level * (class1SkillsperLevel + _baseAbilityMods[3]));
            }
        }


        public bool[] IsClassSkill
        {
            set
            {
                //Check each value to see if it's true
                for (int i = 0; i < isClassSkill.Length; i++)
                {
                    //if the current value is false set it to the new value
                    if (!isClassSkill[i])
                    {
                        isClassSkill[i] = value[i];
                    }
                    for (int j = 0; j < isThemeClassSkill.Length; j++)//if the class skill is also granted by theme player gets a plus 1
                    {
                        if (isThemeClassSkill[j] && isClassSkill[j])
                        {
                            unnamedSkillBounus[j] = 1;
                        }
                    }
                }
            }//end set
            get
            {
                return isClassSkill;
            }
        }//end IsClassSkill

        public int PlayerLevel
        {
            get
            {
                playerLevel = Class1Level + Class2Level;
                return playerLevel;
            }
        }

        public int PlayerBAB
        {
            get
            {
                if (MultiClass)
                {
                    playerBAB = BAB1 + BAB2;
                }
                else
                {
                    playerBAB = BAB1;
                }
                return playerBAB;
            }
        }//end PlayerBAB

        /// <summary>Ability Scores After all Bonuses</summary>
        public int[] AbilityScores
        {
            get
            {
                for (int i = 0; i < abilityScoresFinal.Length; i++)
                {
                    abilityScoresFinal[i]= _baseAbilityScores[i] + (themeAblityScoreAdjustment[i] + RacialAbilityScoreAdjustment[i]);
                }
                return abilityScoresFinal;
            }
        }
        /// <summary> Statmina points ajusted by Class Con mod and Ability Scores</summary>
        public int StaminaPoints
        {
            get
            {
                if ((Class1Level * (Class1ConMod + _baseAbilityMods[1])) + (Class2Level * (Class2ConMod + _baseAbilityMods[1])) < 0)
                {
                    return 0;
                }
                else
                {
                    return (Class1Level * (Class1ConMod + _baseAbilityMods[1])) + (Class2Level * (Class2ConMod + _baseAbilityMods[1]));
                }
            }
        }//end StaminaPoints

        public int HitPoints
        {
            get
            {
                return (Class1HPMod * Class1Level) + (Class2HPMod * Class2Level) + RaceHPMod;
            }
        }

        public bool[] Is_TrainedOnlySkill
        {
            set
            {
                isTrainedOnlySkill = value;
            }
            get
            {
                return isTrainedOnlySkill;
            }
        }

        public int[] AbilityModForSkill
        {
            get
            {
                return abilityUsedForSkill;
            }
            set
            {
                abilityUsedForSkill = value;
            }
        }

        public int[] Skills
        {
            get
            {
                return skills;
            }
            set
            {
                skills = value;
            }
        }


        /// <summary>Ability Mods from Base Character Attributes</summary>
        public int[] BaseAbilityMods
        {
            get
            {
                return _baseAbilityMods;
            }
            set
            {
                _baseAbilityMods = value;
            }
        }

        /// <summary>Base scores without Theme mods or race mods</summary>
        public int[] BaseAbilityScores
        {
            set
            {
                _baseAbilityScores = value;
            }
            get
            {
                return _baseAbilityScores;
            }
        }
        //For Rich text formats where \r does't work.
        private static string cr()
        {
            return Environment.NewLine;
        }
    }//end PlayerCharacter class
}//end namespace
