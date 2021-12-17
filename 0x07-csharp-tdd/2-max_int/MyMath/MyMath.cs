using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>METHODS TO DO ARITMETHIC FUNTIONS</summary>
    public class Operations
    {
        /// <summary>method to return the max integer in a list of integers</summary>
        public static int Max(List<int> nums)
        {
            if (nums == null)
                return 0;

            int max_integer = 0;

            foreach (int num in nums)
            {
                if(num > max_integer)
                    max_integer = num;
            }
            return max_integer;
        }
    }
}
