using System;
using System.Collections.Generic;
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> results = new List<int>();
        try
        {
            int index = 0;

            for (; index < listLength; index++) 
            {
                int result = list1[index] / list2[index];
                results.Add(result);
            }
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            results.Add(0);
        }
        catch(Exception)
        {
            Console.WriteLine("Out of range");
        }
        return results;
    }
}

