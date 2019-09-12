using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLib
{
    /// <summary>
    /// This class contains definitions for the PlayerClass Class that is unique to the Envoy Player Class
    /// </summary>
    public class EnvoyClass :PlayerClass
    {
        //class Constants
        private const int CLASS_ID = 0;// set Envoy ID number
        private const int HP = 6;
        private const int CON_MOD = 6;
        private const int SKILLS_PER_LV = 8;

        //created to make predictive text save me some typing :)
        private string envoy_Imp = "Envoy Improvisation";
        private string exp_tal = "Expertise Talent";
        private string skill_Exp = "Skill Expertise";

        /// <summary>Read only, Useful for calcualting the leves at wich and amount of Improvisation the class recives </summary>
        public int[] GetsImprovisation { get; } = { 0, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11 };//first address is ignored 
        /// <summary>Read only, Useful for calcualting the leves at wich and amount of Expertise the class recives </summary>
        public int[] GetsExpertiseTallent { get; } = { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5 };//first address is ignored
        /// <summary>Read only, Useful for calcualting the leves at wich and amount of Expertise the class recives </summary>
        public int[] GetsSkillExpterise { get; } = { 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5 };//first address is ignored
        public readonly bool[] isClassSkill = { true, true, true, true, true, true, true, true, true, false, true,
            false, true, false,true,true,true, true, true, false };
        public readonly string[] ClassSkillNames = { "Acrobatics", "Athletics", "Bluff", "Computers", "Culture",
            "Diplomacy", "Disguise", "Engineering", "Intimidate", "Medicine", "Perception", "Piloting", "Profession",
            "Sense Motive", "Sleight of Hand", "Stealth" };


        public int SkillsPerLevel
        {
            get
            {
                skillsPerLevel = SKILLS_PER_LV; //8
                return SKILLS_PER_LV;
            }
        }

        public string ClassName
        {
            get
            {
                return classNames[CLASS_ID];
            }
        }

        public int ConMod
        {
            get
            {
                return CON_MOD;
            }
        }

        public int HPMod
        {
            get
            {
                return HP;
            }
        }
        public int[] FortSaves
        {
            get
            {
                fortSaves = weakSaves;
                return fortSaves;
            }
        }

        public int[] RefSaves
        {
            get
            {
                refSaves = strongSaves;
                return refSaves;
            }
        }

        public int[] WillSaves
        {
            get
            {
                willSaves = strongSaves;
                return willSaves;
            }
        }


        public int[][] Saves
        {
            get
            {
                savingThrows[0] = FortSaves;
                savingThrows[1] = RefSaves;
                savingThrows[2] = WillSaves;
                return savingThrows;
            }
        }

        public string[][] ClassFeatures //[class level]
        {
            get
            {
                classFeatures[0] = new string[] { "error: class level = 0" };//not used
                classFeatures[1] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString() };
                classFeatures[2] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString() };
                classFeatures[3] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[4] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[5] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[6] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[7] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[8] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[9] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[10] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[11] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[12] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[13] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[14] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[15] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[16] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[17] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[18] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[19] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization" };
                classFeatures[20] = new string[] { Expertise(ClassLevel), skill_Exp + " X" + GetsSkillExpterise[ClassLevel].ToString(),
                    envoy_Imp + " X" + GetsImprovisation[ClassLevel].ToString(),
                        exp_tal + " X" + GetsImprovisation[ClassLevel].ToString(), "Weapon Specialization", "True Expertise" };
                return classFeatures;
            }
        }// end ClassFeatures

        /// <summary>read only, returns the BAB for the class bassed on class level</summary>
        public int BAB
        {
            get
            {
                return ClassBABs[CLASS_ID][ClassLevel];
            }
        }

        /// <summary>sets Class profiencies to true then returns the list</summary>
        public bool[] areProfiencies
        {
            get
            {
                weaponProficiency[0] = true;//Basic Melee
                weaponProficiency[2] = true;//small arms
                weaponProficiency[6] = true;//Granades
                return weaponProficiency;
            }
        }

        /// <summary>
        /// Generates a string showing the character's current Experise die and bonuses based on level
        /// </summary>
        /// <param name="level">Class level</param>
        /// <returns>A string for humans</returns>
        public string Expertise(int level)
        {
            string exp;
            if (level < 5)
            {
                exp = "Expertise (1d6)";
            }
            else if (level < 9)
            {
                exp = "Expertise (1d6+1)";
            }
            else if (level < 13)
            {
                exp = "Expertise (1d6+2)";
            }
            else if (level < 17)
            {
                exp = "Expertise (1d8+2)";
            }
            else if (level < 20)
            {
                exp = "Expertise (1d8+3)";
            }
            else if (level == 20)
            {
                exp = "Expertise (1d8+4)";
            }
            else
            {
                exp = "Error";
            }//end if
            return exp;
        }//end Expertise
    }
}
