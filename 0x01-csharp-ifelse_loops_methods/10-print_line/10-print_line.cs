using System;

class Line
{
    public static void PrintLine(int length)
    {
        string line = "";
        for (; length > 0; length--)
        {
            line += "_";
        }
        Console.WriteLine(line);
    }
}
