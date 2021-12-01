using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_1 = 0;
            int num_2 = 0;
            string line = "";
            for(;num_1 < 10; num_1++)
            {
                num_2 = num_1 + 1;
                for (; num_2 < 10; num_2++)
                {
                    if (num_1 == 8 && num_2 == 9)
                        line +=num_1.ToString("d") + num_2.ToString("d");
                    else
                    {
                        line +=num_1.ToString("d") + num_2.ToString("d") + "," + " ";
                    }
                }
            }
            Console.WriteLine(line);

        }
    }
}
