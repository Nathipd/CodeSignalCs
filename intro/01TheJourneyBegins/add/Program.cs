using System;

//Write a function that returns the sum of two numbers.

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution(1, 2);
        }

        static int Solution(int param1, int param2)
        {

             int _sum = param1 + param2;

            Console.Write($"{param1} + {param2} = {_sum}");

            return _sum;

        }
    }
}