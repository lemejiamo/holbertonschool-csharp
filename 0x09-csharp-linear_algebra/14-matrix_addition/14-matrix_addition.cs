using System;
using System.Linq;
/// <summary>
/// Contains all the Method used to handle vectors and matrix
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method to adds two matrix
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] new_Matrix = new double[matrix1.GetLength(0), matrix1.GetLength(1)];
        int i = 0, j = 0;

        if (matrix1.Length != matrix2.Length)
            return new double[,] { { -1 } };

        for (; i < matrix1.GetLength(0); i++)
        {
            for (j = 0; j < matrix1.GetLength(1); j++)
            {
                new_Matrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        
        return new_Matrix;
    }

    /*static void Main(string[] args)
    {
        double[,] matrix = { { 1, 2 }, { 3, 4 }, { 5, 8} };
        double[,] matrix2 = { { 1, 2 }, { 3, 4 }, { 3, 7}, { 3, 8} };
        double[,] result;
        int i = 0, j = 0;
        result = Add(matrix, matrix2);

        for (i = 0; i < result.GetLength(0); i++)
        {
            for (j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j]);
                if (j != result.GetLength(1) - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }*/
}
