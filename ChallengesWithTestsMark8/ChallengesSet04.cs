using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            foreach (var num in numbers)
            {
                if(num %2 == 0)
                {
                    result += num;
                }
                else
                {
                    result -= num;
                }
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var str = new string[] { str1, str2, str3, str4 };
            int minLength = str.Min(y => y.Length);
            return minLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var str = new int[] { number1, number2, number3, number4 };
            int min = str.Min();
            return min;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            var Evens = new List<int>();
            if (numbers != null)
            {
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        Evens.Add(num);
                    }
                }
                double average = Evens.Sum() / Evens.Count;
                if(Evens.Count <= 0)
                {
                    return 0;
                }
                else
                {
                    return average;
                }
            }
            else
            {
                return 0;
            }
            
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
