using System;
using System.Collections.Generic;
using System.Text;

namespace demo_2
{
    internal class array_programs
    {
        public void array()
        {
            int[] no = { 1, 2, 3, 4, 5 };//one dimension array
            int[,] no1 = { { 1, 2 }, { 3, 5 }, { 2, 9 } };//two dimension arra 

            foreach (int i in no)
            {
                Console.WriteLine(i + "--");
            }
            foreach (int i in no1)
            {
                Console.WriteLine(i);
            }
        }
        //Console.WriteLine(no);
        public void array1()
        {
            int[] no = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int no1 = Convert.ToInt32(Console.ReadLine());
            //no.Add(no1);
            double sum = 0;
            int count = 0;
            foreach (int i in no)
            {
                //Console.WriteLine(i);
                sum += i;
                count += 1;
            }
            Console.WriteLine("Total Sum is :" + sum);
            double avg = (sum / count);
            Console.WriteLine("Avvrage is :" + avg);

        }
        public void array2()
        {
            int[] no = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            double odd_sum = 0;
            double even_sum = 0;
            foreach (int i in no)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i + ": No is Odd");
                    odd_sum += i;
                }
                else
                {
                    Console.WriteLine("--->" + i + " Even");
                    even_sum += i;
                }

            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Sum Of Odd No is :" + odd_sum);
            Console.WriteLine("Sum Of Even No is :" + even_sum);
        }
        public void array3()
        {
            int[] no = { 1, 2, 3, -1, 4, 0, 5, -3, 10 };
            double pos_sum = 0;
            double neg_sum = 0;
            int neg_count = 0;
            int pos_count = 0;

            foreach (int i in no)
            {
                if (i < 0)
                {
                    //Console.WriteLine(i + ":is negative");
                    neg_sum += i;
                    neg_count += 1;
                }
                else if (i > 0)
                {
                    //Console.WriteLine(i + " --------->is Positive");
                    pos_sum += i;
                    pos_count += 1;
                }
                else
                {
                    Console.WriteLine(i);

                }
            }
            Console.WriteLine("=============================");
            Console.WriteLine("Nagative No Count -> " + neg_count);
            Console.WriteLine("Positive No Count -> " + pos_count);
            Console.WriteLine();
            Console.WriteLine("Negative No Sum :" + neg_sum);
            Console.WriteLine("Positive No Sum :" + pos_sum);
        }
        public void noMinMax()
        {
            int[] no = { 1, 2, 3, 4, 5, 0, 6, 7, 8, 9, 10 };
            int min = 1;
            int max = 0;
            foreach (int i in no)
            {
                if (i == 0)
                {
                    //Console.WriteLine("no is Zero");
                    min = i;
                }
                else if (i > max)
                {
                    max = i;
                }
                else
                {
                    min = i;
                }
            }
            Console.WriteLine("Max no : " + max);
            Console.WriteLine("Min No : " + min);
        }
        public void strArray()
        {
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //foreach (char ch in input)
            //{
            //    //Console.WriteLine(ch);
            //}
            //---------print charecter using for loop------------


            string str = "kevin";//hint :- char acces from index
            int count = 0;

            foreach (char i in str)
            {
                count += 1;
            }

            for (int i = 0; i <= count - 1; i++)//use also  str.Length for get string lenght
            {
                Console.WriteLine(str[i]);
            }

            //-----------------------
            //W
            //WE
            //WEB
            //WEBO
            //WEBOC
            //WEBOCC
            //WEBOCCU
            //WEBOCCUL
            //WEBOCCULT

            //string str = " WEBOCCULT";
            //string end = "";
            //foreach (char i in str)
            //{

            //    end += i;
            //    Console.WriteLine();

            //}

            //Console.WriteLine();
        }
        public void revers()
        {
            string str = "WEBOCCULT";

            string revers = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
                revers += str[i].ToString();
            }
            Console.WriteLine(revers);
        }
        public void AsceDesc()
        {

            string str = "kevin";
            string asce = "";
            string descc = "";
            char c = str[0];
            for (int i = 0; i <= str.Length - 1; i++)//a
            {


                for (int i1 = i + 1; i <= str.Length - 1; i++)//b
                {
                    if (str[i] > str[i1])//b<a
                    {
                        //asce = str[i1];
                        Console.WriteLine(asce);
                    }
                }


            }


        }
        public void bubbleSort()
        {
            int[] arr = { 3, 1, 5, 9, 2, 4, -4, -8 };


            for (int i = 0; i <= arr.Length - 1; i++)//0 1
            {
                for (int j = 0; j < arr.Length - 1; j++)//0 5 -- loop end  at j=4(j) 5(j+1)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        //Console.Write(arr[j]);
                        //Console.WriteLine(arr[j+1]);
                    }
                    foreach (int l in arr)
                    {
                        Console.Write(l);
                    }
                    Console.WriteLine();
                }
                //Console.WriteLine();
            }
        }
        public void selectionSort()
        {
            int[] arr = { 64, 25, 22, 12, 22, 11 };
            //int[] arr = { 4, 2, 1, 5, 0, 3 }; //legth 6
            //0  1  2  3  4  5

            for (int i = 0; i < arr.Length - 1; i++)
            {

                int Small_index = i;//i is first index 
                for (int j = i + 1; j < arr.Length; j++)//j+1 because i=index1 and compare with next index
                {
                    if (arr[j] < arr[Small_index])
                    {
                        Small_index = j;

                    }

                }
                int temp = arr[i];
                arr[i] = arr[Small_index];
                arr[Small_index] = temp;
            }
            foreach (int k in arr)
            {
                Console.Write(k + " ");
            }
        }
        public void InsertionSort()
        {
            //int[] arr = { 23, 1, 10, 5, 2 };
            //int[] arr = { 23, 1, 10,5 };
            int[] arr = { 34, 12, 78, 23, 45, 9, 56 };
            for (int i = 0; i <arr.Length - 1; i++)
            {
                int Key = i + 1;
                for (int j = 0; j < Key; j++)
                {
                    if (arr[Key] < arr[j])
                    {
                        int temp = arr[Key];
                        arr[Key] = arr[j];
                        arr[j] = temp;
                    }
                }
                foreach (int k in arr)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

