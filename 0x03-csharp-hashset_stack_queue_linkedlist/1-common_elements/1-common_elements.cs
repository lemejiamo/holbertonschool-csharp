﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> return_list = new List<int>();
        
        foreach(int num in list1)
        {
            if(list2.Contains(num))
            {
                return_list.Add(num);
            }
        }

        return return_list;
    }
}