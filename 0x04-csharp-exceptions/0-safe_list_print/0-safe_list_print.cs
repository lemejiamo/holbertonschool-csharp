using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int toPrint = n;
        int printed = 0;
        try
        {
            for(;  printed < toPrint; printed++)
            {
                Console.WriteLine(myList[printed]);
            }
        }
        catch
        {

        }
        return (printed);
    }
}