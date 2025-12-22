using System;
using System.Collections.Generic;
using System.Text;

namespace demo_2
{
    internal class for_loop
    {
        public void forloop()
        {
            Console.WriteLine("Enter NO :");
            int no = int.Parse(Console.ReadLine());

            for (int i = 1; i < no + 1; i--)
            {
                Console.WriteLine(i);
            }

        }
        public void sumofNum()
        {
            Console.WriteLine("Enter NO :");
            int no = int.Parse(Console.ReadLine());
            int sum = 0;


            for (int i = 0; i < no + 1; i++)
            {
                sum += i;//sum=sum+i

            }
            int avg = sum / no;
            Console.WriteLine("sum of all number :", sum);
            Console.WriteLine("average", avg);

        }
        public void odd_even()
        {
            Console.WriteLine("Enter NO :");
            int no = int.Parse(Console.ReadLine());

            for (int i = 1; i < no + 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} even no ");
                    //break;
                }
                else
                {
                    Console.WriteLine($"{i}No is odd");
                    //break;
                }

            }
        }
        public void factorial()
        {
            Console.WriteLine("Enter NO for:");
            int no = int.Parse(Console.ReadLine());

            int fact = 1;

            for (int i = 1; i < no + 1; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"factorial of {no} is :" + fact);

        }
        public void sum_odd_even()
        {
            Console.WriteLine("Enter NO :");
            int no = int.Parse(Console.ReadLine());
            int oddCount = 0;
            int evenCount = 0;
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i < no + 1; i++)
            {
                if (i % 2 == 0)
                {
                    evenCount++;
                    evenSum += i;
                }
                else
                {
                    oddCount++;
                    oddSum += i;
                }
            }
            Console.WriteLine($"sum of even is :{evenSum} and counte of no is {evenCount}");
            Console.WriteLine($"sum of odd is :{oddSum} and counte of no is {oddCount}");

        }

        public void fibonaki()
        {
            Console.WriteLine("Enter NO :");
            int no = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c;

            for (int i = 0; i < no; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(a);
            }


        }
        public void series()
        {
            Console.WriteLine("Enter NO :");
            int no = int.Parse(Console.ReadLine());
            //1 5 2 4 3 3 4 2 5 1…….N

            for (int i = 1; i < no + 1; i++)
            {
                int v = no - i + 1;
                Console.Write($"{i},{v},");
            }


        }
        public void alphabet()
        {
            //Console.WriteLine("Enter Alphabets");
            //char first_alphabett = Console.ReadKey().KeyChar;
            //[ABCDE….Z] 
            //[Aa Bb Cc ….. Zz]

            for (char i = 'A'; i <= 'Z'; i++)
            {

                string v = i.ToString();
                Console.Write($"{i}{v.ToLower()} ");
            }


        }
        public void no_pyaramid()
        {
            Console.WriteLine("Enter NO :");
            int no = int.Parse(Console.ReadLine());

            //1
            //12
            //123
            //1234……N
            for (int i = 1; i <= no + 1; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            //--------------------------------------------
            //12345
            //1234
            //123
            //12
            //1

            //for (int i = no; i >=1; i--)
            //{
            //    
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
