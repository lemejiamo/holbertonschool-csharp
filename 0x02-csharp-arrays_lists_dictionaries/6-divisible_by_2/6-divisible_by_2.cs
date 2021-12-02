using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {

        List<bool>  results = new List<bool>();
        int len = myList.Count;
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return null;
        }

        for (int i = 0; i < len; i++ )
        {
            if (myList[i] % 2 == 0)
                results.Add(true);
            else
            {
                results.Add(false);
            }
        }
        return results;
    }
}