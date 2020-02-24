using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM_Assignment_2
{
    class Question_7
    {

        static int powercalc(int x, int b)
        {
            int fl = 1;
            while (b > 0)
            {
                if ((b & 1) > 0)
                    fl = fl * x;
                x = x * x;
                b >>= 1;
            }
            return fl;
        }

        // Basicaly the aim is to Break the number(Rod) into its maximum product
        static int breakrod(int N)
        {
            // First Situtaion: 2 = 1 + 1  
            if (N == 2)
                return 1;

            // Situation 3 = 2 + 1  
            if (N == 3)
                return 2;

            int maxpro = -1;

            // Breaking with mod = 3  
            switch (N % 3)
            {

                case 0:
                    maxpro = powercalc(3, N / 3);
                    break;

                // If modulus as =1, then break as  4 + power of 3 for the remaining   
                case 1:
                    maxpro = 2 * 2 * powercalc(3, (N / 3) - 1);
                    break;

                // If division gives modulus = 2, then break as 2 + power of 3 for remaining   
                case 2:
                    maxpro = 2 * powercalc(3, N / 3);
                    break;
            }
            return maxpro;
        }

        public static void Main()
        {
            int maxpro = breakrod(15);
            Console.WriteLine(maxpro);
        }
    }
}