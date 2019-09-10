using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLib
{
    /// <summary>
    /// This class stores data about Starfinder Themes.
    /// </summary>
    public class Themes
    {
        private string[][] _benifits = new string[10][];
        private string[] _sources;
        private int[][] _themes = new int[10][];
        //ability buffs based on selected theme   {cha,con,dex,int,str,wis}
        private int[] _acePilotThemeAbilityScoreAdj = { 0, 0, 1, 0, 0, 0 };
        private int[] _bountyHunterThemeAbilityScoreAdj = { 0, 1, 0, 0, 0, 0 };
        private int[] _iconThemeAbilityScoreAdj = { 1, 0, 0, 0, 0, 0 };
        private int[] _mercenaryThemeAbilityScoreAdj = { 0, 0, 0, 0, 1, 0 };
        private int[] _outLawThemeAbilityScoreAdj = { 0, 0, 1, 0, 0, 0 };
        private int[] _priestThemeAbilityScoreAdj = { 0, 0, 0, 0, 0, 1 };
        private int[] _scholarThemeAbilityScoreAdj = { 0, 0, 0, 1, 0, 0 };
        private int[] _spacefarerThemeAbilityScoreAdj = { 0, 1, 0, 0, 0, 0 };
        private int[] _xenoSeekerThemeAbilityScoreAdj = { 1, 0, 0, 0, 0, 0 };
        private int[] _themelessAbilityScoreAdj = { 0, 0, 0, 0, 0, 0 }; //bonus chosen by user

        /// <summary>An array of string names for all Core themes</summary>
        public string[] ThemeNames = { "AcePilot", "bountyHunter", "Icon",
            "Mercenary", "Outlaw", "Priest", "Scholar", "Spacefarer", "Xenoseeker", "Themless" }; //0-9

        //benifits gained at 1st, 6th 12th and 18th level.
        private string[] _aceBenefits = { "Theme Knowledge (Ace)", "Lone Wolf", "Need for Speed", "Master Pilot" };
        private string[] _bountyHunterBenefits = { "Theme Knowledge (Bounty Hunter)", "Swift Hunter", "Relentless", "Master Hunter" };
        private string[] _iconBenefits = { "Theme Knowledge (Icon)", "Celeberity", "Megacelebrity", "Master Icon" };
        private string[] _mercBenefits = { "Theme Knowledge (Merc)", "Grunt", "Squad Leader", "Commander" };
        private string[] _outlawBenefits = { "Theme Knowledge (Outlaw)", "Legal Corruption", "Black Market Connection", "Master Outlaw" };
        private string[] _priestBenefits = { "Theme Knowledge (Priest)", "Mantle of the Clergy", "Divine Boon", "True Communion" };
        private string[] _scholarBenefits = { "Theme Knowledge (Scholar)", "Tip of the Tongue", "Research Maven", "Master Scholar" };
        private string[] _spacerBenefits = { "Theme Knowledge (Spacer)", "Eager Dabbler", "Jack of all Trades", "Master Explorer" };
        private string[] _xenoBenefits = { "Theme Knowledge (Xeno)", "Quick Pidgin", "First Contact", "Brilliant Discovery" };
        private string[] _themlessBenefits = { "General Knowledge (Themeless)", "Certainty", "Extensive Studies", "Steely Determination" };

        //Theme description properties
        /// <summary>Read only Array of benefit description strings for the Ace Pilot Theme</summary>
        public string[] AceBenefits
        {
            get
            {
                return _aceBenefits;
            }
        }

        /// <summary>Read only Array of benefit description strings for the Bounty Hunter Theme</summary>
        public string[] BountyHunterBenefits
        {
            get
            {
                return _bountyHunterBenefits;
            }
        }

        /// <summary>Read only Array of benefit description strings for the Icon Theme</summary>
        public string[] IconBenefits
        {
            get
            {
                return _iconBenefits;
            }
        }

        /// <summary>Read only Array of benefit description strings for the Mercenary Theme</summary>
        public string[] MercenaryBenefits
        {
            get
            {
                return _mercBenefits;
            }
        }

        /// <summary>Read only Array of benefit description strings for the Outlaw Theme</summary>
        public string[] OutlawBenefits
        {
            get
            {
                return _outlawBenefits;
            }
        }

        /// <summary>Read only Array of benefit description strings for the Priest Theme</summary>
        public string[] PriestBenefits
        {
            get
            {
                return _priestBenefits;
            }
        }

        /// <summary>Read only Array of benefit description strings for the Scholar Theme</summary>
        public string[] ScholarBenefits
        {
            get
            {
                return _scholarBenefits;
            }
        }

        /// <summary>Read only Array of benefit description strings for the Spacefarer Theme</summary>
        public string[] SpacefererBenefits
        {
            get
            {
                return _spacerBenefits;
            }
        }

        /// <summary>Read only Array of benefit description strings for the Xenoseeker Theme</summary>
        public string[] XenoseekerBenefits
        {
            get
            {
                return _xenoBenefits;
            }
        }

        //ability score adjustment properties
        /// <summary>Read only Array of ability score adjustments for the Ace Pilot Theme</summary>
        public int[] AceAbilityAdjustment
        {
            get
            {
                return _acePilotThemeAbilityScoreAdj;
            }
        }

        /// <summary>Read only Array of ability score adjustments for the Bounty Hunter Theme</summary>
        public int[] BountyHunterAbilityAdjustment
        {
            get
            {
                return _bountyHunterThemeAbilityScoreAdj;
            }
        }

        /// <summary>Read only Array of ability score adjustments for the Icon Theme</summary>
        public int[] IconAbilityAdjustment
        {
            get
            {
                return _iconThemeAbilityScoreAdj;
            }
        }

        /// <summary>Read only Array of ability score adjustments for the Mercenary Theme</summary>
        public int[] MercAbilityAdjustment
        {
            get
            {
                return _mercenaryThemeAbilityScoreAdj;
            }
        }

        /// <summary>Read only Array of ability score adjustments for the Outlaw Theme</summary>
        public int[] OutlawAbilityAdjustment
        {
            get
            {
                return _outLawThemeAbilityScoreAdj;
            }
        }

        /// <summary>Read only Array of ability score adjustments for the Priest Theme</summary>
        public int[] PriestAbilityAdjustment
        {
            get
            {
                return _priestThemeAbilityScoreAdj;
            }
        }

        /// <summary>Read only Array of ability score adjustments for the Scholar Theme</summary>
        public int[] ScholarAbilityAdjustment
        {
            get
            {
                return _scholarThemeAbilityScoreAdj;
            }
        }

        /// <summary>Read only Array of ability score adjustments for the Spaceferer Theme</summary>
        public int[] SpacerAbilityAdjustment
        {
            get
            {
                return _spacefarerThemeAbilityScoreAdj;
            }
        }

        /// <summary>Read only Array of ability score adjustments for the Xenoseeker Theme</summary>
        public int[] XenoAbilityAdjustment
        {
            get
            {
                return _xenoSeekerThemeAbilityScoreAdj;
            }
        }

        /// <summary>Read only Array of ability score adjustments for the Themeless Theme</summary>
        public int[] ThemelessAbilityAdjustment
        {
            get
            {
                return _themelessAbilityScoreAdj;
            }
        }

        /// <summary>
        /// Produces an array of int used to determine which abaility score needs to be adjusted
        /// </summary>
        /// <param name="themeId">Theme ID int</param>
        /// <returns>An array of ints parallel to the ability scores array</returns>
        public int[] ThemeAbilityScoresAdj(int themeId)
        {
            //check to see if a theme has been chosen yet
            if (themeId < 0)
            {
                //no theme chosen yet.
                return _themelessAbilityScoreAdj;
                //returns an array of zeros
            }
            else
            {
                _themes[0] = _acePilotThemeAbilityScoreAdj;
                _themes[1] = _bountyHunterThemeAbilityScoreAdj;
                _themes[2] = _iconThemeAbilityScoreAdj;
                _themes[3] = _mercenaryThemeAbilityScoreAdj;
                _themes[4] = _outLawThemeAbilityScoreAdj;
                _themes[5] = _priestThemeAbilityScoreAdj;
                _themes[6] = _scholarThemeAbilityScoreAdj;
                _themes[7] = _spacefarerThemeAbilityScoreAdj;
                _themes[8] = _xenoSeekerThemeAbilityScoreAdj;
                _themes[9] = _themelessAbilityScoreAdj;
                return _themes[themeId];
            } 
        }

        /// <summary>
        /// an array of theme sources ordered by theme ID
        /// </summary>
        /// <param name="themeId">Theme ID int</param>
        /// <returns>A string contianing The source of the theme</returns>
        public string[] Sources(int themeId)
        {
            for (int i = 0; i < 10; i++)
            {
                _sources[i] = "Core Rule Book";
            }
            return _sources;
        }
    }
}
