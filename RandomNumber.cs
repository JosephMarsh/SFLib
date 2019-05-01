using System;
using System.Security.Cryptography;

namespace SFLib
{
    /// <summary>
    /// This class contains a method for randomly generating numbers
    /// </summary>
    public class RandomNumber
    {
        

        //this class was orrigonally published by Scott Lilly
        //then slighly modified by Joseph Marsh
        //code was found on https://scottlilly.com/create-better-random-numbers-in-c/

        private static readonly RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        /// <summary>
        /// Generates a psudo-random number
        /// </summary>
        /// <param name="minValue">Lowest Number</param>
        /// <param name="maxValue">Highest Number +1</param>
        /// <returns>Random Int</returns>
        public static int Between(int minValue, int maxValue)
        {
            byte[] rando = new byte[1];

            rng.GetBytes(rando);

            double valueOfChar = Convert.ToDouble(rando[0]);

            // We are using Math.Max, and substracting 0.00000000001, 
            // to ensure "multiplier" will always be between 0.0 and .99999999999
            // Otherwise, it's possible for it to be "1", which causes problems in our rounding.
            double numMultiplier = Math.Max(0, (valueOfChar / 255d) - 0.00000000001d);

            // We need to add one to the range, to allow for the rounding done with Math.Floor
            int range = maxValue - minValue + 1;

            double randValue = Math.Floor(numMultiplier * range);

            return (int)(minValue + randValue);
        }
    }
}
