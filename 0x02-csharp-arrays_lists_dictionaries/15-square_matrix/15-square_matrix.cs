using System;
using System.Collections.Generic;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int columns = myMatrix.GetLength(1);
        int[,] new_Array = new int[rows, columns];

        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                new_Array[i,j] = myMatrix[i,j] *  myMatrix[i,j];
            }
        }
        return new_Array;

    }
}
