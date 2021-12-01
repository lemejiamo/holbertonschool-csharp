using System;


class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
        }
        else
        {
            int len = (array.Length - 1);
            for (;len >= 0; len--)
            {
                Console.Write("{0}{1}", array[len], len == 0 ? "" : " " );
            }
        }
    }
}