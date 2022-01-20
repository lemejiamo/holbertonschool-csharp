using System;
using System.Linq;
/// <summary>
/// Contains all the Method used to handle vectors and matrix
/// </summary>
class VectorMath
{
    /// <summary>
    /// MEthod to calculate the dot product betewen to vectors 
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>
    /// returns a new vector with the result
    /// </returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        // basis vector
        double i = 1, j = 1, k = 1;
        double magnitude_vector1, magnitude_vector2;
        double[] v1 = vector1;
        double[] v2 = vector2;
        double dot_Product = 0;

        //Verify if the two vectors has the same Length
        var x = vector1.Length != vector2.Length ? 1 : 0;
        if (x == 1)
           return -3;

        /// Funt to calculate the Magnitude of a vector
        Func<double[], double> Magnitude = vector => Math.Round(Math.Sqrt(vector.Aggregate((accum, current) => accum + (current * current))), 2);

        magnitude_vector1 = Magnitude(v1);
        magnitude_vector2 = Magnitude(v2);

        // Method to calculate dot product formula A.B= Ax*Bx + Ay*By + Az*Bz

        for (int o = 0; o < v1.Length; o++)
        {
            dot_Product += v1[o] * v2[o];
        }

        return dot_Product;

    }

    /*static void Main(string[] args)
    {
        double[] v1 = new double[3] { 1, 4, 5 };
        double[] v2= new double[3] { 15, 44, 35 };

        var exe = DotProduct(v1, v2);
        Console.WriteLine(exe);
        
    }*/
}
