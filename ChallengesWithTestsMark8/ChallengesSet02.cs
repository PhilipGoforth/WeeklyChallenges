using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers.Count() == 0 && numbers != null)
            {
                return 0;
            }
            else if (numbers != null)
            {
                return numbers.Min() + numbers.Max();
            }
             else
            {
                return 0;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers != null)
            {
                return numbers.Sum();
            }
            else
            {
                return 0;
            }
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
            if (numbers != null)
            {
                if (numbers.Sum() % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            
                long count = 0;
                for(var i = number-1; i > 0; i--)
                {
                    if(i %2 != 0)
                    {
                        count++;
                    }
                }
                return count;
            
        }
    }
}
