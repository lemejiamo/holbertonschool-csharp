using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        int max = 0;

        // Console.WriteLine("{0}", myList.Count);

        int len = myList.Count;

        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return (-1);
        }

        foreach (int number in myList)
        {
            if (number > max)
                max = number;
        }
        return max;
    }
}