using System;
using System.Collections.Generic;

namespace ISM_Assignment_2
{
    class Question_8
    {
        static void Main(string[] args)
        {
            // WriteLine statement asking user input for size of the User dictionary
            Console.WriteLine("Enter size of list");  

            // Input is read as a string, converting it into integer. This is for the keyword parameter to be passed to the method
            int n = Convert.ToInt32(Console.ReadLine());

            // Take user inputs for the elements of a Dictionary
            Console.WriteLine("Enter keyword");

            // Taking in string input from the user for checking whether it's present in the dictionary with a letter changed or not
            String input = Console.ReadLine();
            
            // Creating a string array with the length specified previously by the user as (n)
            String[] s1 = new String[n];

            // Writeline statement asking user to input strings into the string array
            Console.WriteLine("Enter list of strings");

            // iterating through the string array for gathering inputs 
            for (int i = 0; i < n; i++)
            {
                // taking inputs for s1[i] till i reaches the string array length n 
                s1[i] = Console.ReadLine();
            }


            // Calling the function DictSearch which has a return value of Boolean and storing it in a boolean variable 
            // DictSearch takes in user input in the form of a string array s1 & user input as keyword
            bool a = DictSearch(s1, input);

            // Printing the result of the boolean variable a
            Console.WriteLine(a);

            Console.ReadLine();
        }

        // Method to determine character change in input and return a boolean value
        public static bool DictSearch(string[] userDict, string keyword)
        {
            // initializing count variable to 0
            int count = 0;

            // declaring a temp variable
            String temp;

            // for loop to iterate through the first till the length of the string array(s1) which we passed as an argument to this function
            for (int i = 0; i < userDict.Length; i++)
            {
                // storing the i'th element in the temp variable 
                temp = userDict[i];

                // initializing count to 0
                count = 0;

                // checking whether the length of the first element of userDict is equal to the length of the keyword/input provided
                if (userDict[i].Length == keyword.Length)
                {
                    // if true program would enter this loop & iterate through the letters of the element
                    for (int j = 0; j < userDict[i].Length; j++)
                    {
                        // if the j'th element of userDict stored in temp is not equal to the j'th element of the input 
                        // this condition would increment the count value
                        if (temp[j] != keyword[j])
                        {
                            count++;
                        }

                    }
                }

                // this will return true if the previous if statement along with the nested if is true and the count is equal to 1 
                if (count == 1)
                {
                    return true;
                }
            }
            // the return value would be set to false if the first condition inside the method is false or if the nested condition is false
            return false;
        }
    }
}
