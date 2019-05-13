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
    public class Theme
    {
        private string[][] _benifits = new string[10][];
        private string[] _sources;
        public int[][] themes = new int[10][];
        //ability buffs based on selected theme   {cha,con,dex,int,str,wis}
        public readonly int[] acePilotTheme = { 0, 0, 1, 0, 0, 0 };
        public readonly int[] bountyHunterTheme = { 0, 1, 0, 0, 0, 0 };
        public readonly int[] iconTheme = { 1, 0, 0, 0, 0, 0 };
        public readonly int[] mercenaryTheme = { 0, 0, 0, 0, 1, 0 };
        public readonly int[] outLawTheme = { 0, 0, 1, 0, 0, 0 };
        public readonly int[] priestTheme = { 0, 0, 0, 0, 0, 1 };
        public readonly int[] scholarTheme = { 0, 0, 0, 1, 0, 0 };
        public readonly int[] spacefarerTheme = { 0, 1, 0, 0, 0, 0 };
        public readonly int[] xenoSeekerTheme = { 1, 0, 0, 0, 0, 0 };
        public readonly int[] themeless = { 0, 0, 0, 0, 0, 0 }; //bonus chosen by user

        public string[] ThemeNames = { "AcePilot", "bountyHunter", "Icon",
            "Mercenary", "Outlaw", "Priest", "Scholar", "Spacefarer", "Xenoseeker", "Themless" }; //0-9

        //benifits gained at 1st, 6th 12th and 18th level.
        public readonly string[] aceBenefits = { "Theme Knowledge (Ace)", "Lone Wolf", "Need for Speed", "Master Pilot" };
        public readonly string[] bountyHunterBenefits = { "Theme Knowledge (Bounty Hunter)", "Swift Hunter", "Relentless", "Master Hunter" };
        public readonly string[] iconBenefits = { "Theme Knowledge (Icon)", "Celeberity", "Megacelebrity", "Master Icon" };
        public readonly string[] MercBenefits = { "Theme Knowledge (Merc)", "Grunt", "Squad Leader", "Commander" };
        public readonly string[] outlawBenefits = { "Theme Knowledge (Outlaw)", "Legal Corruption", "Black Market Connection", "Master Outlaw" };
        public readonly string[] PriestBenefits = { "Theme Knowledge (Priest)", "Mantle of the Clergy", "Divine Boon", "True Communion" };
        public readonly string[] scolarBenefits = { "Theme Knowledge (Scholar)", "Tip of the Tongue", "Research Maven", "Master Scholar" };
        public readonly string[] SpacerBenefits = { "Theme Knowledge (Spacer)", "Eager Dabbler", "Jack of all Trades", "Master Explorer" };
        public readonly string[] xenoBenefits = { "Theme Knowledge (Xeno)", "Quick Pidgin", "First Contact", "Brilliant Discovery" };
        public readonly string[] themlessBenefits = { "General Knowledge (Themeless)", "Certainty", "Extensive Studies", "Steely Determination" };

        public string[][] ThemeBenefits
        {
            get
            {
                _benifits[0] = aceBenefits;
                _benifits[1] = bountyHunterBenefits;
                _benifits[2] = iconBenefits;
                _benifits[3] = MercBenefits;
                _benifits[4] = outlawBenefits;
                _benifits[5] = PriestBenefits;
                _benifits[6] = scolarBenefits;
                _benifits[7] = SpacerBenefits;
                _benifits[8] = xenoBenefits;
                _benifits[9] = themlessBenefits;
                return _benifits;
            }
        }//ThemeBenefits

        public int[] ThemeAbilityScoresMod(int themeId)
        {
            themes[0] = acePilotTheme;
            themes[1] = bountyHunterTheme;
            themes[2] = iconTheme;
            themes[3] = mercenaryTheme;
            themes[4] = outLawTheme;
            themes[5] = priestTheme;
            themes[6] = scholarTheme;
            themes[7] = spacefarerTheme;
            themes[8] = xenoSeekerTheme;
            themes[9] = themeless;
            return themes[themeId];
        }
        /// <summary>
        /// an array of theme sources ordered by theme ID
        /// </summary>
        /// <param name="themeId">Theme ID</param>
        /// <returns>A string contianing The source of the theme</returns>
        public string[] Sources(int themeId)
        {
            for (int i = 0; i < 10; i++)
            {
                _sources[i] = "Core Rule Book";
            }
            return _sources;
        }

        public Theme()
        {
        }
    }
}
