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
    public class Race
    {
        
        public int[][] races = new int[9][];
        public int[] raceHPMod = { 4, 4, 4, 4, 4, 6, 6, 2, 4 };

        public readonly int[] androidMods = { -2, 0, 2, 2, 0, 0 };
        public readonly int[] humanMods = { 0, 0, 0, 0, 0, 0 };
        public readonly int[] kasathaMods = { 0, 0, 0, -2, 2, 2 };
        public readonly int[] lashuntaDMods = { 2, -2, 0, 2, 0, 0 };
        public readonly int[] lashuntaKMods = { 2, 0, 0, 0, 2, -2 };
        public readonly int[] shirrenMods = { -2, 2, 0, 0, 0, 2 };
        public readonly int[] veskMods = { 0, 2, 0, -2, 2, 0 };
        public readonly int[] YoskiMods = { 0, 0, 2, 2, -2, 0 };
        public readonly int[] otherRaceMods = { 0, 0, 0, 0, 0, 0 };
        public readonly string[] raceNames = { "Android", "Human", "Kasatha", "Lashunta[Damaya]",
            "Lashunta[Korasha]", "Shirren", "Vesk", "Yoski", "other" };

        public string getRaceName(int raceID)
        {
            return raceNames[raceID];
        }



        public int[][] RaceMods
        {
            get
            {
                races[0] = androidMods;
                races[1] = humanMods;
                races[2] = kasathaMods;
                races[3] = lashuntaDMods;
                races[4] = lashuntaKMods;
                races[5] = shirrenMods;
                races[6] = veskMods;
                races[7] = YoskiMods;
                races[8] = otherRaceMods;
                return races;
            }
        }


        public int[] getClassArray(int classId)//race stat mods
        {
            races[0] = androidMods;
            races[1] = humanMods;
            races[2] = kasathaMods;
            races[3] = lashuntaDMods;
            races[4] = lashuntaKMods;
            races[5] = shirrenMods;
            races[6] = veskMods;
            races[7] = YoskiMods;
            races[8] = otherRaceMods;
            return races[classId];
        }
    }
}
