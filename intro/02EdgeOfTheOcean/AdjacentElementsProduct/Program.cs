using System;

// Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.

namespace AdjacentElementsProduct
{
    class Program
    {
        static void Main(string[] args) 
        {

            Solution(new int[] {3, 6, -2, -5, 7, 3});
        }

        static int Solution(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(i);
            }

            return 0;
        }

    }
}