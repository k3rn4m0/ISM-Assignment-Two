using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISM_Assignment_2
{
    class Question_5
    {
        static void Main(string[] args)
        {

            // WriteLine statement asking user input for the length of first array
            Console.WriteLine("Enter length of first array");
            
            // type conversion of input length a of first array m1
            int a = Convert.ToInt32(Console.ReadLine());

            // WriteLine statement asking user input for the length of second array
            Console.WriteLine("Enter length of second array");

            // type conversion of input length b of second array m2
            int b = Convert.ToInt32(Console.ReadLine());

            // Declaring two integer arrays m1 and m2 with lengths a & b respectively
            int[] m1 = new int[a]; 
            int[] m2 = new int[b];
            
            // WriteLine statement seeking input for the first array
            Console.WriteLine("Enter first array");

            // for loop that iterates and stores input in the first array
            for (int i = 0; i < a; i++)
            {
                // m1[i] stores the ith element in integer array m1 till i < length of the first array i.e. a
                m1[i] = Convert.ToInt32(Console.ReadLine());
            }

            // WriteLine statement seeking input for the second array
            Console.WriteLine("Enter second array");

            // for loop that iterates and stores input in the second array
            for (int i = 0; i < b; i++)
            {
                // m2[i] stores the ith element in integer array m2 till i < length of the second array i.e. b
                m2[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calling methof Intersect1 & storing the output in an integer array 'c'
            int[] c = Intersect1(m1, m2);

            // Iterating through the elements of c & printing out the array
            foreach (int k in c)
            {
                Console.Write(k + " ");
            }
            Console.Read();
        }


        // Function that computes intersection of two arrays
        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            // Checking whether either of the arrays are shorter and assigning it to an integer array  int[] shorter
            int[] shorter = nums1.Length < nums2.Length ? nums1 : nums2;

            // Checking whether either of the arrays are longer and assigning it to an integer array  int[] longer
            int[] longer = nums1.Length < nums2.Length ? nums2 : nums1;

            // Creating Extra space for the shorter of the 2 arrays
            Dictionary<int, int> map = new Dictionary<int, int>(); // declaring a Dictionary called Map
            foreach (int x in shorter)
            {
                // checking whether the Dictionary contains the key & incrementing the value to the next
                if (map.ContainsKey(x)) map[x]++; 

                // or assign 1 to the dictionary element
                else map[x] = 1;
            }

            // will print the intersection of both the arrays using Lists & returns that list in the form of array
            IList<int> inter = new List<int>();
            foreach (int x in longer)
            {
                if (map.ContainsKey(x) && map[x]-- > 0) inter.Add(x);
            }

            return inter.ToArray();
        }
    }

}