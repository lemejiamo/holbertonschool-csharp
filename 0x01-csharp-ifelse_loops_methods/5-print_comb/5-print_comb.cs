using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "";
            for (int num = 0; num < 100; num++)
            {
                if (num < 10)
                {
                    cadena += '0' + num.ToString("d") + ',' +  ' ';
                }
                else if (num == 99)
                {
                    cadena +=  num.ToString("d");
                }
                else
                {
                    cadena += num.ToString("d") + ',' +  ' ';
                }

            }
            Console.Write(cadena);

        }
    }
}
