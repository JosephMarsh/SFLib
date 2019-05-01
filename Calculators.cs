using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLib
{
    /// <summary>
    /// This Class contiants usefull RGP calcuation methods.
    /// </summary>
    public class Calculators
    {
        /// <summary>
        /// This Method accepts a raw ability score between 7 and 18 and calculates its cost in point-buy points
        /// </summary>
        /// <param name="abilityScore">(int)Raw ability Score</param>
        /// <returns>(int)pointbuy cost for one ability score</returns>
        public int Point_BuyCostCalc(int abilityScore)
        {
            switch (abilityScore)
            {
                case 7:
                    return -4;
                case 8:
                    return -2;
                case 9:
                    return -1;
                case 10:
                    return 0;
                case 11:
                    return 1;
                case 12:
                    return 2;
                case 13:
                    return 3;
                case 14:
                    return 5;
                case 15:
                    return 7;
                case 16:
                    return 10;
                case 17:
                    return 13;
                case 18:
                    return 17;
                default:
                    //point by cost can only be calculated from 7 to 18
                    if (abilityScore > 18)
                    {
                        return 17;
                    }
                    else
                    {
                        return -4;
                    }
            }//end switch
        }//end PointCostCalc

        /// <summary>
        /// This Method accepts a raw ability score and and outputs the Ability Score Bonus
        /// </summary>
        /// <param name="AbilityScore">(int)Raw Ability Score</param>
        /// <returns>(int)Ability Score Bonus</returns>
        public int modCalc(int AbilityScore)
        {
            int modifier;
            //Math.floor requires numbers to be in decimal.
            modifier = (int)Math.Floor((AbilityScore - 10d) / 2d);
            return modifier;
        }//end modCalc

    }

}
