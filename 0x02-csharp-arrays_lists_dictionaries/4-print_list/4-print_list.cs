using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int>  _list = new List<int>();
        int i = 0;
        if (size <= 0)
        {
            Console.WriteLine();
            return null;
        }
        do
        {
            _list.Add(i);
            Console.Write("{0}{1}", i, i == (size - 1) ? "\n" : " ");
            i++;
        }while(i < size);

        return _list;
    }
}