using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceTopics
{
    public delegate void mydel(int a, int b);
    public delegate string strdel(string name);
    internal class Delegates
    {
        //non static method
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        //static method
         static public string Say(string name)
        {
            //Console.WriteLine("Hello "+name);
            return name;
        }

        public static int add(int a,int b)
        {
            return a + b;
        }
    }
}
