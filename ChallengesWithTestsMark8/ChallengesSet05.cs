using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            while(startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var item in businesses)
            {
                if(item.TotalRevenue == 0)
                {
                    item.Name = "CLOSED";
                }
            }
        }
        public static bool checkEquality<T>(T[] numbers, T[] inOrder)
        {
            return Enumerable.SequenceEqual(numbers, inOrder);
        }
        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers != null && numbers.Length > 0)
            {
                var inOrder = new List<int>();
                foreach (var num in numbers)
                {
                    inOrder.Add(num);
                }
                inOrder.Sort();

                return checkEquality(numbers, inOrder.ToArray());
            }
            else
            {
                return false;
            }
            
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers != null)
            {
                var numList = new List<int>();
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0 && i != numbers.Length - 1)
                    {
                         numList.Add(numbers[i + 1]);
                    }
                }
                return numList.Sum();
            }
            else
            {
                return 0;
            }

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words != null && words.Length > 0)
            {

                foreach (var str in words)
                {
                    var charsToRemove = new string[] { " " };
                    foreach (var c in charsToRemove)
                    {
                       str.Replace(c, string.Empty);
                    }
                }
                return $"{String.Join(" ", words)}.";
                
            }
            else
            {
                return "";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var answer = new double[0];
            if (elements != null)
            {
                var newElements = new List<double>();
                for (var i = 3; i < elements.Count; i += 4)
                {
                    var num = elements[i];
                    newElements.Add(num);
                }
                return newElements.ToArray();
            }
            else
            {
                return answer;
            }
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            var numList = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if(i != j)
                    {
                        numList.Add(nums[i] + nums[j]);
                    }
                }
            }
            if (numList.Contains(targetNumber))
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
