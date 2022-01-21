using System;
/// <summary>
/// 
/// </summary>
class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        double det = -1;
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            det = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            return (Math.Round(det, 2));
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            det = ((matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]))) - (matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]))) + (matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]))));
            return (Math.Round(det, 2));
        }
        else
        {
            return (det);
        }
    }

    
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] identity_Matrix = new double[,] { { 1, 0 }, { 0, 1 } };
        double[,] tem_matrix = new double[2, 4];
        double[] vector1 = new double[4];
        double[] vector2 = new double[4];
        double factor1 = matrix[1, 1];
        double factor2 = matrix[0,1];

        if (Determinant(matrix) == 0)
            return new double[,] { { -1 } };

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        if (matrix[0, 1] != 0)
        {

            if (matrix[1, 1] > 0 && matrix[0, 1] > 0)
                factor1 = factor1 * -1;

            vector1[0] = matrix[0, 0] * factor1;
            vector1[1] = matrix[0, 1] * factor1;
            vector1[2] = identity_Matrix[0, 0] * factor1;
            vector1[3] = identity_Matrix[0, 1] * factor1;
            vector2[0] = matrix[1, 0] * factor2;
            vector2[1] = matrix[1, 1] * factor2;
            vector2[2] = identity_Matrix[1, 0] * factor2;
            vector2[3] = identity_Matrix[1, 1] * factor2;
            
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < tem_matrix.GetLength(1); j++)
                {
                    tem_matrix[i, j] = vector1[j] + vector2[j];
                }
            }
        }

        if (matrix[1, 0] != 0)
        {
            factor1 = matrix[1, 0];
            factor2 = matrix[0, 0];

            if (factor1 > 0 && factor2 > 0)
                factor1 = factor1 * -1;

            vector1[0] = matrix[0, 0] * factor1;
            vector1[1] = matrix[0, 1] * factor1;
            vector1[2] = identity_Matrix[0, 0] * factor1;
            vector1[3] = identity_Matrix[0, 1] * factor1;
            vector2[0] = matrix[1, 0] * factor2;
            vector2[1] = matrix[1, 1] * factor2;
            vector2[2] = identity_Matrix[1, 0] * factor2;
            vector2[3] = identity_Matrix[1, 1] * factor2;

            for (int i = 1; i <=1 ; i++)
            {
                for (int j = 0; j< tem_matrix.GetLength(1); j++)
                {
                    tem_matrix[i, j] = vector1[j] + vector2[j];
                }
            }
        }

        if (tem_matrix[0,0] != 1)
        {
            factor1 = tem_matrix[0,0];

            for(int i = 0; i < 1; i++)
            {

                for (int j = 0; j< tem_matrix.GetLength(1); j++)
                {
                    tem_matrix[i, j] = tem_matrix[i,j] / factor1;
                }
            }
        }

        if (tem_matrix[1, 1] != 1)
        {
            factor1 = tem_matrix[1, 1];

            for (int i = 1; i == 1; i++)
            {
                for (int j = 0; j < tem_matrix.GetLength(1); j++)
                {
                    tem_matrix[i, j] = tem_matrix[i, j] / factor1;
                }
            }
        }

        for (int i = 0; i<2; i++ )
        {
            for(int j = 2; j<4; j++)
            {
                identity_Matrix[i, j-2] = tem_matrix[i, j];
            }
        }

        return identity_Matrix;
    }
}
