using System;

namespace _100_hello_error
{
    class Program
    {
        static void Main(string[] args)
        {
            string error = "and that piece of art is useful - Dora Korpar, 2015-10-19";
            Console.Error.WriteLine("{0}", error);
            Environment.Exit(1);
        }
    }
}
