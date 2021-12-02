using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> add_numbers = new HashSet<int>();
        int count = 0;

        foreach(int num in myList)
        {
            if (add_numbers.Contains(num) == false)
            {
                add_numbers.Add(num);
                count += num;
            }
        }
        return count;
    }
}