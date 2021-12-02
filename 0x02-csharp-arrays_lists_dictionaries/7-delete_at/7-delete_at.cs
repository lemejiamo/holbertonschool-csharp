using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        int len = myList.Count;
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return null;
        }
        else if (index > len)
        {
            Console.WriteLine("Index is out of range");
            return null;
        }
        myList.Remove(index);

        return myList;
    }
}