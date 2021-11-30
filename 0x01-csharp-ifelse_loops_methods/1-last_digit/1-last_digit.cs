using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int last_digit = number % 10;
        do
        {
            if (last_digit > 9)
            {
                last_digit = last_digit % 10;
                Console.WriteLine($"{last_digit}");
            }
        }while (last_digit > 9);
        if (last_digit < 6)
        {
            Console.WriteLine($"The last digit of {number} is {last_digit} and is less than 6 and not 0");
        }
        else if (last_digit > 5)
        {
            Console.WriteLine($"The last digit of {number} is {last_digit} and is greater than 5");
        }
        else if (last_digit == 0)
        {
            Console.WriteLine($"The last digit of {number} is {last_digit} and is 0");
        }
    }
}