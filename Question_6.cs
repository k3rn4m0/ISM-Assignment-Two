using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Question 1");
            // Setting up the array to be searched on and target value
            string[] old = new string[] { "a", "b", "c", "d", "a"};
            int k = 9;
            Console.WriteLine(TargetRange(old, k));
            Console.ReadLine();
        }
        public static bool TargetRange(string[] arr, int x)
        {
            // Creating the dictionary to keep track of count of each character
            Dictionary<string, int> arrDict = new Dictionary<string, int>();
            // Loop to make the dictionary and  check for the condition
            for (int i = 0; i < arr.Length; i++)
            {
                if (arrDict.ContainsKey(arr[i]))
                {
                    if (Math.Abs(i - arrDict[arr[i]]) <=x)
                    {
                        // True is returned if the condition is met
                        return true;
                    }
                }
                else
                {
                    
                    arrDict.Add(new KeyValuePair<string, int>(arr[i], i));
                }
            }
            return false
            // False is returned if the condition is never met
        }
    }
}
