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
            int i = 1;
            while (i <= 5)
            {
                //Console.Write(i); 1 2
                int j = 1; //1 2 
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                i++;
                Console.WriteLine();
            }
        }
        public void loop2()
        {
            int no = 5;
            int i = no;

            //12345
            //1234
            //123
            //12
            //1

            while (i >= 1)
            {
                int j = 1;
                while (j <= i)
                {
                    Console.Write(j);
                    j++;
                }
                Console.WriteLine();
                i--;
            }


            //54321
            //5432
            //543
            //54
            //5
            //int no = 5;
            //int i = 1;
            //while (i<=no)
            //{
            //    int j = no;//5 
            //    while (j>=i)//5>=2 
            //    {
            //        Console.Write(j);
            //        j--;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            //---

            //5
            //54
            //543
            //5432
            //54321

            //int no = 5;
            //int i = no;
            //while (i >= 1)//54321
            //{
            //    int j = no;
            //    while (j >= i)
            //    {
            //        Console.Write(j);
            //        j--;
            //    }
            //    Console.WriteLine();
            //    i--;
            //}


            //-----

            //1
            //12
            //123
            //1234

            //int no = 4;
            //int i = 1;
            //while (i <= no)
            //{
            //    int j = 1;
            //    while (j<=i)
            //    {
            //        Console.Write(j);
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}


            //------

            //1  2  3  4  5
            //6  7  5  9
            //10 11 12
            //13 14
            //15

            //int no = 5;
            //int i = no;
            //int newvar = 1;
            //while(i>=1)
            //{
            //    int j = 1;
            //    while (j <= i)
            //    {
            //        Console.Write(newvar+"  ");
            //        newvar += 1;
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i--;
            //}
            //------

            //10 9 8 7
            //6 5 4
            //3 2
            //1

            //int no = 4;
            //int i = 1;
            //int sum = 0;
            //while (i <= no)
            //{
            //    sum += i;
            //    i++;

            //}

            //int i1 =no;
            //while (i1 >= 1)
            //{
            //    //Console.WriteLine(i1);
            //    int j1 =1;
            //    while(j1 <=i1)
            //    {
            //        Console.Write(sum+" ");
            //        sum -= 1;
            //        j1++;
            //    }
            //    Console.WriteLine();
            //    i1--;
            //}

            //-----



            //char c = 'd';
            //char c1 = 'a';
            //while (c1 <= c)
            //{
            //    //Console.WriteLine(c1);
            //    char j = 'a';
            //    while (j <= c1)
            //    {
            //        Console.Write(j);
            //        j++;


            //    }
            //    Console.WriteLine();
            //    c1++;
            //}
            //------
            //dcba
            //cba
            //ba
            //a
            //char c = 'd';

            //char i = c;
            //while(i >= 'a')
            //{

            //    char j = i;
            //    while (j >= 'a')
            //    {
            //        Console.Write(j);
            //        j--;
            //    }
            //    Console.WriteLine();
            //    i--;
            //}
        }


        public void revers()
        {

            int no = 1243, revers = 0;

            while (no != 0)
            {
                int k = no % 10;//3 4 2 1
                revers = revers * 10 + k; //3421
                no /= 10;//124  12 1
            }
            Console.WriteLine(revers);
        }


        public void sum()
        {
            int no = 8513;
            int last_digit = 0;
            int remain_no = 0;
            int sum = 0;
            //int i = 1;

            while (no != 0)
            {
                last_digit = no % 10;
                remain_no = no /= 10;
                sum += last_digit;
                //i++;
            }
            Console.WriteLine(sum);
        }

        public void palindrome()
        {
            int no = 121;
            int old_no = no;
            int revers = 0;
            while (no != 0)
            {
                int last = no % 10;
                revers = revers * 10 + last;
                no /= 10;
            }
            //Console.WriteLine(revers);
            //Console.WriteLine(old_no);
            Console.WriteLine((old_no == revers) ? old_no + " Is Palindrome" : old_no + " Is Not Palindrome ");


        }

        public void armstrongNo()
        {
            int no = 153;
            int temp = no;
            int orignalNo = no;
            double sum = 0;
            int Digitcount = 0;

            while (temp > 0)
            {
                 Digitcount+= 1;
                temp /= 10;
            }
            Console.WriteLine(Digitcount);
            while (no != 0)
            {
                int last = no % 10;
                no /= 10;
                sum += Math.Pow(last, Digitcount);//last digit * no(3*3*3//5*5*5//1*1*1*)

            }
            Console.WriteLine((sum == orignalNo) ? orignalNo + "Is Armstrong":orignalNo+" IS not Armstrong");

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