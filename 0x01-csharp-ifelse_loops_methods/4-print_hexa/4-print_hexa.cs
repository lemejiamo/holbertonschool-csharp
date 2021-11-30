using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec_num = 0;
            for (; dec_num < 99; dec_num++)
            {
                string hex = dec_num.ToString("X");
                Console.WriteLine($"{dec_num} = 0x{hex}");
            }

        }
    }
}
