using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFLib
{
    /// <summary>
    /// Class Stores Methods for Generating Random Die Rolls
    /// </summary>
    public class DiceRollMethods
    {

        /// <summary>
        /// rolls 2 dice drops the lowest and adds the 3rd is always a 6
        /// </summary>
        /// <param name="dice">Array of int</param>
        /// <param name="re_Roll_1s">if true will not return less than 2</param>
        /// <returns>Array of 3 ints</returns>
        public int[] HeroicDieRoll(int[] dice, bool re_Roll_1s= false )
        {
            int a = -1;
            for (int x = 1; x < 7; x++)
            {
                int[] d6s = new int[3];

                for (int i = 0; i <= d6s.Length - 1; i++)
                {
                    d6s[i] = RollD6(re_Roll_1s);
                }//end for
                Array.Sort(d6s);
                a++;
                dice[a] = d6s[1];
                a++;
                dice[a] = d6s[2];
                a++;
                dice[a] = 6;
            }//end for
            return dice;
        }//end heroic 

        /// <summary>
        /// rolls 4 dice drops, the lowest and adds the 3 hightest to an array
        /// </summary>
        /// <param name="dice">Array of int</param>
        /// <param name="re_Roll_1s">if true will not return less than 2</param>
        /// <returns>Array of 3 ints</returns>
        public int[] StandardDieRoll(int[] dice, bool re_Roll_1s = false)
        {
            int a = -1;
            for (int x = 1; x < 7; x++)
            {
                int[] d6s = new int[4];

                for (int i = 0; i <= d6s.Length - 1; i++)
                {
                    d6s[i] = RollD6(re_Roll_1s);
                }//end inner for
                Array.Sort(d6s);
                a++;
                dice[a] = d6s[1];
                a++;
                dice[a] = d6s[2];
                a++;
                dice[a] = d6s[3];
            }//end outter for
            return dice;
        }// end standardDieRoll

        /// <summary>
        /// Generates psudo-random number between 1 and 6
        /// </summary>
        /// <param name="re_Roll_1s">if true will not return less than 2</param>
        /// <returns>int between 1 and 6 or 2 and 6</returns>
        public int RollD6(bool re_Roll_1s = false)
        {
            int num;
            int num2;

            if (re_Roll_1s)
            {
                do
                {
                    do
                    {
                        num = RandomNumber.Between(1, 7);
                        num2 = RandomNumber.Between(1, 7);
                    } while (num != num2 || (num > 6)); //inner while
                    // Makes the Algorythm "Feel" more random
                } while (num == 1);//outter while
            }
            else
            {
                do
                {
                    num = RandomNumber.Between(1, 7);
                    num2 = RandomNumber.Between(1, 7);
                } while ((num < 1) || (num > 6));//end loop
            }//end if 
            return num;
        }//end Roll D6

    }//end Class
}//end Namespace
