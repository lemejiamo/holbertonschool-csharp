using System;
class Array
{
    public static int[] CreatePrint(int size)
    {

        if (size == 0)
            Console.WriteLine();
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = i;
            Console.Write("{0}{1}", i, i == (size - 1)? "\n" : " ");
        }
        // Console.WriteLine("Array Length: {0}", size);
        return array;
    }
}
