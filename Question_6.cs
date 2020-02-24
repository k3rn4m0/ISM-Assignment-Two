using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_Assignment_2
{
    class Question_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Question 1");
            // Creating list with required numbers and setting target number

            int[] l1 = new int[] { 1, 2, 2, 2, 2, 3, 4, 7, 8, 8 };
            int target = 8;
            List<int> r = TargetRange(l1, target);
            foreach (int a in r)
            {
                Console.WriteLine("Output " + a);
            }

            Console.ReadLine();
        }
        public static List<int> TargetRange(int[] arr, int x)
        {
            int n = arr.Length;
            int first = -1, last = -1;
            // Setting n as the length of the array and first and last values

            // Logic is to to during each iteration, check from the beginning and end for the target value
            for (int i = 0; i < n; i++)
            {
                if (x != arr[i])
                    continue;
                if (first == -1)
                    first = i;
                last = i;
            }
            //  Craeting an object and adding the required first and last values. Returning them at the end
            if (first != -1)
            {
                var obj = new List<int>();
                obj.Add(first);
                obj.Add(last);
                return (obj);
            }
            else
            {
                var obj = new List<int>();
                obj.Add(first);
                obj.Add(last);
                return (obj);
            }
        }
    }
}
