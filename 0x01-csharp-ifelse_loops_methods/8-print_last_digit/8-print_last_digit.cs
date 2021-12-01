using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        if (number < 0)
            number = number * -1;
        int last_digit = number % 10;
        do
        {
            if (last_digit > 9)
            {
                last_digit = last_digit % 10;
            }
        }while (last_digit > 9);
        Console.Write(last_digit);
        return last_digit;
    }
}