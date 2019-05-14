using System;
using System.Collections.Generic;
using System.Numerics;

namespace FibonacciProject
{
    public class Fibonacci
    {
        public static List<BigInteger> GetFibonacciValues()
        {
            var listValues = new List<BigInteger>();
            listValues.Add(1);
            listValues.Add(1);
            
            BigInteger a = 1;
            BigInteger b = 1;
            
            for (int i = 3; i <= 120; i++)
            {
                b = a + b;
                a = b - a;
                
                listValues.Add(b);
            }

            return listValues;
        }
    }
}