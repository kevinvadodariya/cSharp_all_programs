using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace demo_2
{
    internal class while_loop
    {
        public void loop()
        {
            int i = 10;
            while (i <= 15)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public void loop2()
        {
            int n = 10, sum = 0, i = 1;

            while (i <= n)
            {

                sum += i;
                Console.WriteLine(sum);
                i++;
            }
            Console.WriteLine(sum);


        }
        public void star()
        {

            int no = 5, i = 1;
            while (i <= no)
            {
                //Console.WriteLine("*");

                int j = 2;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine("*");
                i++;
            }
        }

        public void revers() {

            int no = 1243, revers = 0;

            while (no!=0)
            {
                int k = no % 10;
                revers = revers * 10 + k;
                no/=10;
            }
            Console.WriteLine(revers);  
        }

        public void conti()
        {
            int i = 0, no = 5;

            while (i <= no)
            {
                i++;
                if (i == 3)
                    continue;
                Console.WriteLine(i);
                
            }
        }
    }
}