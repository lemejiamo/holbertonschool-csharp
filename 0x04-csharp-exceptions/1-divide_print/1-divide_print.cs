using System;

class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;

        try
        {
            result =  a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine("{1} // {2} = {3}", a, b, result);
        }
    }
}
