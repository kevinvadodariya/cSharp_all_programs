using System;
using System.Collections.Generic;
using System.Text;

namespace demo_2
{
    internal class if_else
    {
        public void if_else1()
        {
            int no = int.Parse(Console.ReadLine());
            if (no % 5 == 0 && no % 11 == 0)
            {
                Console.WriteLine(" is divisible");
            }
            else
            {
                Console.WriteLine("not");
            }
        }
        public void if_else2()
        {
            int no1 = 12;
            int no2 = 12;
            int no3 = 12;


            if (no1 == no2 && no2 == no3 && no3 == no1)
            {
                Console.WriteLine("no are same");
            }
            else if (no1 > no2 && no1 > no3)
            {
                Console.WriteLine($"{no1} is big");
            }
            else if (no2 > no1 && no2 > no3)
            {
                Console.WriteLine($"{no2} is big");
            }
            else
            {
                Console.WriteLine($"{no3} is big");
            }


        }
        public void if_else3()
        {
            string Char1 = Console.ReadLine();
            //string Char1 = "hello";
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };


            foreach (char char1 in Char1)
            {
                bool isvowels = false;
                //Console.WriteLine(char1);
                foreach (char vowel in vowels)
                {

                    if (char1 == vowel)
                    {
                        isvowels = true;
                        break;

                    }
                }
                if (isvowels)
                {
                    Console.WriteLine(char1 + " :- vowela");
                }
                else
                {
                    Console.WriteLine(char1);
                }
            }
            //if (Char1 == "a" || Char1 == "e" || Char1 == "i" || Char1 == "o" || Char1 == "u")
            //{
            //    Console.WriteLine("char is vowels");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}
        }
       
    }
}
