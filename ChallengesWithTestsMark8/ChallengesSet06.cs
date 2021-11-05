using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool answer = false;
            if (words != null)
            {
                
                if (ignoreCase)
                {
                    foreach (var str in words)
                    {
                        if (str != null)
                        {
                            if (str.ToLower() == word.ToLower())
                            {
                                answer = true;
                            }
                        }
                    }
                }
                else 
                {
                    foreach (var str in words)
                    {
                        if(str == word)
                        {
                            answer = true;
                        }
                    }
                }
            }
           
            return answer;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num > 0)
            {
                int i;
                for (i = 2; i <= num - 1; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                if (i == num)
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

        public int IndexOfLastUniqueLetter(string str)
        {

            int i = str.Length -1;
            if (i >= 0)
            {
                var index = -1;
                for (i = 0; i < str.Length; i++)
                {
                    var letterCount = 0;
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str[i] == str[j])
                        {
                            letterCount++;
                        }
                    }
                    if (letterCount == 1)
                    {
                        index = i;
                    }
                    
                }
                
                return index;
            }
            else
            {
                return -1;
            }

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var dummy = new double[0];
            if (elements != null && n > 0)
            {
                var newElements = new List<double>();
                for (int i = n - 1; i < elements.Count; i += n)
                {
                    newElements.Add(elements[i]);
                }
                return newElements.ToArray();
            }
            else
            {
                return dummy;
            }
        }
    }
}
