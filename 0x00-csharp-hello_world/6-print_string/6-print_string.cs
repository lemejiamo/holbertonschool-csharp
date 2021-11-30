using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
        string b = str.Substring(0,9);
        Console.WriteLine("{0}{0}{0}", str);
        Console.WriteLine("{0}", b);
        }
}