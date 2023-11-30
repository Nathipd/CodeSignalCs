using System;
using System.Xml.Linq;

// Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.

namespace AdjacentElementsProduct
{
    class Program
    {
        static void Main(string[] args)
        {

            Solution(new int[] { 3, 6, -2, -5, 7, 3 });

        }

        static int Solution(int[] inputarray)
        {
            int _inputLength = inputarray.Length;

            int _biggersProduct = int.MinValue;

            for (int i = 0; i < _inputLength -1; i++)
            {

                int _currentIndex = i;
                int _nextIndex = _currentIndex + 1;

                int _currentElement = inputarray[_currentIndex];
                int _nextElement = inputarray[_nextIndex];

                int _product = _currentElement * _nextElement;

                if (_product > _biggersProduct)
                {
                   _biggersProduct = _product;
                }

            }

            Console.WriteLine(_biggersProduct);

            return 0;
        }

    }
}