﻿using System;

class Program
{
    static void Main(string[] args)
    {
        string error = "and that piece of art is useful - Dora Korpar, 2015-10-19";
        Console.Error.WriteLine($"{error}");
        Environment.Exit(1);
    }
}