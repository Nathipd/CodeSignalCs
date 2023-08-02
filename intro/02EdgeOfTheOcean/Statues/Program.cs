using System;

//Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue having an non-negative integer size. Since he likes to make things perfect,
//he wants to arrange them from smallest to largest so that each statue will be bigger than the previous one exactly by 1. He may need some additional statues to be able to accomplish that.
//Help him figure out the minimum number of additional statues needed.

namespace Statues
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution(new int[] { 6, 2, 3, 8 });
        }

        static int Solution(int[] statues)
        {
            int _arrayLenght = statues.Length;
            int _biggerValue = statues.Max();
            int _ciggerValue = statues.Min();
            int _remainingStatues = 0;

            for (int _currentNumber = _ciggerValue; _currentNumber <= _biggerValue; _currentNumber++)
            {
                bool _exist = false;

                for (int i = 0; i < _arrayLenght; i++)
                {
                    if (_currentNumber == statues[i])
                    {
                        Console.WriteLine(statues[i]);
                        _exist = true;

                        break;
                    }
                }
                if (!_exist)
                {
                    _remainingStatues++;
                }
            }

            return _remainingStatues;
        }

    }
}