using System;

class MatrixMath 
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] product = new double[] { 0, 0, 0 };

        if (vector1.Length != 3 || vector2.Length != 3)
            return new double[] { -1 };

        /* calculate the factors*/
        product[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
        product[1] = (vector1[0] * vector2[2]) - (vector1[2] * vector2[0]);
        product[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);

        return product;
    }
}
