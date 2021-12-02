﻿using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        foreach(KeyValuePair<string, string> entry in myDict.OrderBy(key => key.Key))
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

    }
}