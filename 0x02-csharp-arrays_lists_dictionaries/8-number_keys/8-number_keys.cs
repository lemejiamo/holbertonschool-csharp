using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int number_keys = 0;
        foreach (KeyValuePair<string, string> pair in myDict)
        {
            number_keys++;
        }

        return number_keys;
    }
}