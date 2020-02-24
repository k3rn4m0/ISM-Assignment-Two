using System;
using System.Collections.Generic;
using System.Linq;

namespace ISM_Assignment_2
{
    class Question_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 4");
            string s2 = "Dell";
            string sortedString = FreqSort(s2);
            Console.WriteLine(sortedString);
        }
        public static string FreqSort(string s2)

        {

            try
            {
                var frequencyDict = new Dictionary<char, int>(); // assigning frequencydict
                foreach (var character in s2)
                {
                    if (!frequencyDict.ContainsKey(character)) // If it doesn't contain key
                        frequencyDict[character] = 0; // It will set character to 0 if not in dictionary
                    frequencyDict[character]++; // add an increment to frequency dict
                }
                var sortedDict = frequencyDict.OrderByDescending(d => d.Value); // order the dict in descending order
                var result = string.Empty; // Assigns result as empty string
                foreach (var pair in sortedDict)
                {
                    result = result.PadRight(result.Length + pair.Value, pair.Key); // first go through frequency then letter
                }

                return result;


            }
            catch (Exception)
            {
                throw;
            }

            return null;
        }
    }
}