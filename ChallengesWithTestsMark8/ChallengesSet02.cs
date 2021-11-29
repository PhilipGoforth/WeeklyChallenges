using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }


        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null ||numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length > str2.Length) ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            return (numbers != null) ? numbers.Sum() : 0;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers != null)
            {
                var evens = new List<int>();
                for (var i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evens.Add(numbers[i]);
                    }
                }
                numbers = evens.ToArray();
                return numbers.Sum();
            }
            else
            {
                return 0;
            }
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers != null) ? (numbers.Sum() % 2 != 0) : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number <= 0) ? 0 : number / 2;
        }
    }
}
