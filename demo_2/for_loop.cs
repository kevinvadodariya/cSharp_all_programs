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

            //for (int i = no; i >=1; i--)     // i= 5 true ||4 true ||
            //{
            //    
            //    for (int j = 1; j <=i; j++)  // j= 1 true  2 true 3 true 4 true 5 true 6 false
            //                                 // 1 true 2 true 3 true 4 true 5 false
            //    {
            //        Console.Write(j);        // 12345||1234
            //    }
            //    Console.WriteLine();
            //}


        }
        public void pyramid2()
        {
            Console.WriteLine("Enter NO :");
            int no = int.Parse(Console.ReadLine());

            // 3
            // 3 2
            // 3 2 1

            //for (int i = no; i <= no + 1; i++)//i=3 true-- 4 true-- 5false 
            //{
            //    //Console.WriteLine(i);//5
            //    for (int j = no; j <= i; j++)//j=3 true 2false --3true 4true 5false
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine("");
            //}


            // 3 2 1
            // 3 2
            // 3
            for (int i = 1; i <= no; i++)//1true--2true--3true
            {
                //Console.Write(i);
                for (int j = no; j >= i; j--) //3 true 2true 1true--3true 2true 1false--3true 2false
                {
                    Console.Write(j);//321--32--3
                }
                Console.WriteLine(" ");
            }



        }
        public void pyramid3()
        {
            Console.WriteLine("Enter NO :");
            int no = int.Parse(Console.ReadLine());
            //1
            //2 3
            //4 5 6
            //7 8 9 10


            int l = 1;
            for (int i = 0; i <= no; i++)//0true --1 true--2true--3true
            {
                for (int j = 0; j < i; j++)//0 false --0true 1false--0true 1true 2false--
                {
                    Console.Write(l + " ");
                    l += 1;
                }
                Console.WriteLine("");
            }

        }
        public void pyramid4()
        {
            //hint :- sume os number -1
            Console.WriteLine("Enter NO :");
            int no = int.Parse(Console.ReadLine());
            //10 9  8  7
            //6  5  4
            //3  2
            //1
            int sum = 0;
            for (int i = 1; i <= no; i++)//3
            {
                sum += i;
            }
            //Console.Write(sum);
            for (int i = 1; i <= no; i++)//no=4 i=1true--2true--3true--4true--5false
            {

                for (int j = no; j >= i; j--)//4 true 3true 2 true 1true 0false--4true 3true 2true 1false--4true 3true 2false--4true 3false
                {
                    Console.Write(sum + " ");//10 9 8 7--6 5 4--3 2--1
                    sum -= 1;
                }
                Console.WriteLine("");
            }
        }
        public void pyramid5()
        {
            //hint:- set odd position 1 and even 0
            Console.WriteLine("Enter NO :");
            int no = int.Parse(Console.ReadLine());
            //1
            //1 0
            //1 0 1
            //1 0 1 0 
            //1 0 1 0 1……N

            int n = 0;
            for (int i = 1; i <= no + 1; i++)//1 2
            {
                for (int j = 1; j < i; j++)//0 01
                {

                    if (j % 2 == 0)
                    {
                        n = 0;
                        Console.Write(n);

                    }
                    //if (n == 0)
                    else
                    {
                        n = 1;
                        Console.Write(n);
                    }
                }


                Console.WriteLine("");
            }

        }
        public void pyramid6()
        {
            //1
            //01
            //101
            //0101
            //10101…N
            Console.WriteLine("Enter NO :");
            int no = int.Parse(Console.ReadLine());


            //int n = 1;

            for (int i = 1; i <= no + 1; i++)
            {
                for (int j = 0; j < i; j++)//0
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write(1);
                    }
                }

                Console.WriteLine("");
            }

            //if (j % 2 == 0)//0
            //{
            //    if (n == 1)
            //    {
            //        n = 0;
            //    }
            //    else
            //    {
            //        n = 1;//1
            //    }
            //}
            //if (j % 2 == 1)

            //{
            //    if (n == 0)
            //    {
            //        n = 1;
            //    }
            //    else
            //    {
            //        n = 0;
            //    }
            //}

        }
        public void characterSeries()
        {
            Console.WriteLine("Enter Charecater :");
            char usrChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            //A
            //A B
            //A B C
            //A B C D

            //for (char ch = 'A'; ch <= char.ToUpper(usrChar); ch++)
            //{
            //    for (char C = 'A'; C <= ch; C++)
            //    {
            //        Console.Write(C);
            //    }
            //    Console.WriteLine("");

            //}

            //ABCDE
            //ABCD
            //ABC
            //AB
            //A

            for (char ch = char.ToUpper(usrChar); ch >= 'A'; ch--)
            {
                for (char c = 'A'; c <= ch; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }

            //A
            //BC
            //DEF
            //GHIJ
            //char newChar='A';
            //for(char ch='A';ch<= char.ToUpper(usrChar); ch++)
            //{

            //    for(char c = 'A'; c <= ch; c++)
            //    {
            //        Console.Write(newChar);

            //        newChar ++;
            //    }
            //    Console.WriteLine();
            //}
            
        }
    }
}
