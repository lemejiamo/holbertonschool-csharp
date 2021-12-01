using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int i = 0;
        string line = "";


        for(; i < length; i++)
        {
            int spaces = i;

            line = "";

            for ( ; spaces > 0; j--)
                line += " ";

            line += "\\";
            Console.WriteLine(line);
        }
        Console.WriteLine();
    }
}
