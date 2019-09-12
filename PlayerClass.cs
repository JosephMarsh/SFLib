using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLib
{
    /// <summary>
    /// This class stores data common to all Player Classes.  
    /// Individuall classes will inherit from this class.
    /// Once the classes have been cosen, most of the character
    /// creation data can be pulled from here for reference,
    /// though most modifications should come throgh the 
    /// sub classes.
    /// </summary>
    public class PlayerClass
    {
        /// <summary>How many levels the player has in this class </summary>
        public int ClassLevel { get; set; }
        /// <summary>Player's constitution modifier</summary>
        public int ClassConMod { get; set; }
        /// <summary>This Classe's Hit Point modifier</summary>
        public int ClassHPMod { get; set; }
        /// <summary>Can the Player Wear Heavy Armor?</summary>
        protected bool heavyArmor { set; get; }
        /// <summary>Number of Sillponits gaind per level up</summary>
        protected int skillsPerLevel { set; get; }
        /// <summary>Modifies how fast the player can move</summary>
        protected int landSpeedMod { get; set; }
        /// <summary>Stores true if caracter is proficient in weapon runs parrallel with Character.Proficiencies</summary>
        protected bool[] weaponProficiency = new bool[7];//default is false 
        /// <summary>Stors the class ID</summary>
        protected int ClassID { get; set; }
        /// <summary>Array of all class names</summary>
        public readonly string[] classNames = { "Envoy", "Mechanic", "Mystic", "Operative", "Solarian", "Soldier", "Technomancer"};
        /// <summary>Array of all skill names</summary>
        public readonly string[] skillNames = {"Acrobatics", "Athletics", "Bluff", "Computer",
            "Computers", "Culture", "Diplomacy", "Disguise", "Engineering", "Intimidate", "Life Science",
            "Medicine", "Mysticism", "Perception", "Physical Science", "Piloting", "Profession",
            "Sense Motive", "Sleight of Hand", "Stealth", "Survival", "" };
        protected int[][] bassAttackBonusByClassIDByLevels = new int[7][];
        protected string[][] classFeatures = new string[21][];//first address is ignorred  [level][feature]
        protected readonly int[] slowBAB = { 0, 0, 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15 };//first address is ignored
        protected readonly int[] fullBAB = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };//first address is ignored

        protected int[][] spellsPerDay;//first is ignored [classlevel][spell level]
        protected int[][] spellsknown; //first is ignored [classlevel][spell level]


        private string[] keyAttributes = new string[7];
        private string[] secoundaryAttributes = new string[7];

        protected readonly int[] weakSaves = { 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6 };//first address is ignored
        protected readonly int[] poorSaves = { 0, 0, 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15 };//first address is ignored
        protected readonly int[] strongSaves = { 0, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12 };//first address is ignored

        protected int[][] savingThrows = new int[3][];// = [fort, ref, will][level]
        protected int[][] classSaves = new int[21][];
        //first address is ignored 
        protected int[] fortSaves = new int[21];//first address is ignored
        protected int[] refSaves = new int[21];//first address is ignored
        protected int[] willSaves = new int[21];//first address is ignored



        public int[][] ClassBABs
        {
            get
            {
                bassAttackBonusByClassIDByLevels[0] = slowBAB;//envoy
                bassAttackBonusByClassIDByLevels[1] = slowBAB;//Mechanic
                bassAttackBonusByClassIDByLevels[2] = slowBAB;//Mystic
                bassAttackBonusByClassIDByLevels[3] = slowBAB;//Operative
                bassAttackBonusByClassIDByLevels[4] = fullBAB;//Solarian
                bassAttackBonusByClassIDByLevels[5] = fullBAB;//Soldier
                bassAttackBonusByClassIDByLevels[6] = slowBAB;//Technomancer
                return bassAttackBonusByClassIDByLevels;
            }
        }


        //reference materials
        private readonly string[] aName = { "Charsima", "Constitution", "Dexterity", "Intelligence", "Strength", "Wisdom" };



        public string[] KeyAttributes
        {
            get
            {
                keyAttributes[0] = aName[0];//Envoy - cha
                keyAttributes[1] = aName[3];//Mech - int
                keyAttributes[2] = aName[5];//Mystic - wis
                keyAttributes[3] = aName[2];//Operative - dex
                keyAttributes[4] = aName[0];//Solarian - cha
                keyAttributes[5] = aName[4] + " or " + aName[2];//Soldier - str or dex
                keyAttributes[6] = aName[3];//Technomancer - int
                return keyAttributes;
            }
        }//end KeyAttributes

        public string[] SecoundaryAttributes
        {
            get
            {
                secoundaryAttributes[0] = aName[2] + " and " + aName[3];//Envoy - Dex and int
                secoundaryAttributes[1] = aName[2];//Mech - dex
                secoundaryAttributes[2] = aName[0];//Mystic - cha
                secoundaryAttributes[3] = aName[3] + " and " + aName[0];//Operative - int and cha
                secoundaryAttributes[4] = aName[4];//Solarian - str
                secoundaryAttributes[5] = aName[1];//Soldier - con
                secoundaryAttributes[6] = aName[2];//Technomancer - dex
                return secoundaryAttributes;
            }
        }//end SecoundaryAttributes
    }
}
