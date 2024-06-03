using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CSharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>{ 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            foreach(var number in smallests)
            {
                Console.WriteLine(number);
            }

        }

        private static List<int> GetSmallests(List<int> numbers, int v)
        {
            var smallests = new List<int>();
            while(smallests.Count <v)
            {
                var min = GetMin(numbers);
                smallests. Add(min);
                numbers.Remove(min);

            }
            return smallests;
        }

        private static int GetMin(List<int> numbers)
        {
            var min = numbers[0];
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

            }
            return min;
            }
        }
    }
