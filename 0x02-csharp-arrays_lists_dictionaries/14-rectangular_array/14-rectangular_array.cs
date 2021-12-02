using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix  = new int[5 , 5];
            matrix[2,2] = 1;

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(j == 2 && i == 2 )
                        matrix[i,j] = 1;
                    matrix[i,j] = 0;
                    Console.Write("{0}", j < 5-1 ? matrix[i, j] : matrix[i,j] +"\n");
                }
            }

        }
    }
}
