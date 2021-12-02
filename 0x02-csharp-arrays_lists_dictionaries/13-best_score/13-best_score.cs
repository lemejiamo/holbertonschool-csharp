using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = 0;
        string best = "";

        if (myList == null)
            return "None";

        foreach(KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > max)
            {
                max = entry.Value;
                best = entry.Key;
            }
        }
            return best;

    }
}