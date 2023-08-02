using System;

//A 1-interesting polygon is just a square with a side of length 1. An n-interesting polygon is obtained by taking the n - 1-interesting polygon and appending 1-interesting polygons to its rim, side by side.
//Your task is to find the area of a polygon for a given n.

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution(4);
        }

        static int Solution(int n)
        {

            int area = (n * n) + ((n - 1) * (n - 1));

            Console.WriteLine($"The area is {area}");
            return area;
        }

    }
}