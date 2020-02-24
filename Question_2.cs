using System;
using System.Collections.Generic;
using System.Linq;

namespace ISM_Assignment_2
{
    class Question_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 2");
            string s = "University of South Florida";
            string rs = StringReverse(s);
            Console.WriteLine(rs);

        }
        public static string StringReverse(string s)
        {
            int start_index = 0, end_index = s.Length - 1;
            int i = 0, j = 0;
            char[] arr = s.ToCharArray();
            try
            {
                while (start_index < end_index)
                {
                    if (arr[start_index] == ' ') // This checks whether there is a blank space
                    {
                        Console.Write(arr[start_index]);
                        start_index++;
                        i = start_index; // it will increment start index and assign i as value
                    }
                    else
                    {
                        if (arr[i] != ' ') // If array of start index is not a blank
                        {
                            if (i == end_index)
                            {
                                i++;
                                for (j = i - 1; j >= start_index; j--) // if array if start index is not equal to blank, check whether the element is equal blank space.. if not, go into for loop and print array of j.
                                {
                                    Console.Write(arr[j]);
                                }
                                break; // once that is done, it will break
                            }
                            else
                                i++; // increment of i
                        }
                        else
                        {
                            for (j = i - 1; j >= start_index; j--)
                            {
                                Console.Write(arr[j]);
                            }
                            i++;
                            start_index = i - 1;
                        }
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return null;
    
        }
    }
}