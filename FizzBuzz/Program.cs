﻿// See https://aka.ms/new-console-template for more information
using System;

namespace FizzBuzz 
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzbuzz=new FizzBuzz();
            for(int i=1; i<=100; i++)
            {
                Console.WriteLine(fizzbuzz.FizzBuzzfor(i));
            }
        }
    }
}
