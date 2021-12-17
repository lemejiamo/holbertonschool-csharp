using System;

namespace MyMath
{
    /// <summary>METHODS TO DO ARITMETHIC FUNTIONS</summary>
    public class Matrix
    {
        /// <summary>Method to divide a matrix</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }
            if (matrix == null)
            {
                return (null);
            }
            int lenght0, lenght1;

            lenght0 = matrix.GetLength(0);
            lenght1 = matrix.GetLength(1);

            for(int i = 0; i < lenght1; i++)
            {
                for(int j = 0; j < lenght1; j++)
                {
                    matrix[i,j] = matrix[i,j] / num;
                }
            }
            return matrix;
        }
    }
}
