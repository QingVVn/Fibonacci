using System;
using System.Collections.Generic;
using System.Numerics;

namespace FibonacciProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var values = Fibonacci.GetFibonacciValues();
            for (int i = 0; i <120; i++)
            {
                Console.WriteLine(values[i]);
            };
        }
    }
}