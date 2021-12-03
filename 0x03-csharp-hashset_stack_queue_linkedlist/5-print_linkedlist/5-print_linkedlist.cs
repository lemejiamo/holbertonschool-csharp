using System;
using System.Collections.Generic;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{
        int i = 0;
        
		LinkedList<int> linked_list = new LinkedList<int>();
		if (size <= 0)
		{
			return linked_list;
		}
		while(i < size)
		{
			Console.WriteLine(i);
			linked_list.AddLast(i);
            i++;
		}
		return linked_list;
	}
}
