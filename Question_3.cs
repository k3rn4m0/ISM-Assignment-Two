using System;
using System.Collections.Generic;
using System.Text;

namespace ISM_Assignment_2
{
    class Question_3
    {
        static void Main(string[] args)
        {
            // WriteLine statement for asking user input for length of the array
            Console.WriteLine("Enter length of array");

            // Reading user input and doing type conversion
            int a = Convert.ToInt32(Console.ReadLine());

            // declaring an array arr of size a 
            int[] arr = new int[a];

            // WriteLine statement seeking user input for elements of an array
            Console.WriteLine("Enter elements of array");

            // for loop for iterating through the user input and storing it in arr
            for (int i = 0; i < a; i++)
            {
                // storing ith element into arr
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            // declaring an integer result to display minSum() method's output
            int result = minSum(arr);

            // Writeline statement to display the resulting sum
            Console.WriteLine(result);

            Console.ReadLine();
        }

        // Method to make array elements distinct and printing the sum
        public static int minSum(int[] arr)
        {
                // initializing sum to 0
                int sum = 0;
                
                // for loop to traverse through the length of the array
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    // i'th element of the array arr is same as i+1'th element ==  True 
                    if (arr[i] == arr[i + 1])
                    {
                        // increment the i+1'th element & store it in arr[i+1] position
                        arr[i + 1] = arr[i + 1] + 1;
                    }
                }
                
                // Iterating through the array & computing sum
                for (int i = 0; i < arr.Length; i++)
                {
                    sum = sum + arr[i];
                }
                
                // returning sum of the whole array
                return sum;

        }

    }
}
