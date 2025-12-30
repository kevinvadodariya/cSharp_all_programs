using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AdvanceTopics
{
    internal class collection
    {
        //Generic collection
        public void list()
        {
            List<string> list = new List<string>();
            list.Add("Kevin");
            list.Add("2");
            list.Add("Sitara");
            list.Add("baba");
            list.Add("Prince");

            Console.WriteLine(list.Count());
            //list.Remove("2");
            //list.RemoveAt(1);
            Console.WriteLine("Capcity :" + list.Capacity);
            list.Insert(0, "Banana");
            list[0] = "mengo";
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
        }

        public void Dictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "BMW");
            dict.Add(2, "VOLVO");
            dict.Add(3, "AUDI");
            dict.Add(4, "TOYOTA");

            dict.Remove(4);
            Console.WriteLine(dict.Count);
            if (dict.ContainsValue("TOYOTA"))
            {
                Console.WriteLine("Yeh");
            }
            else
            {
                Console.WriteLine("noooooooo");
            }
            foreach (var i in dict)
            {
                Console.WriteLine(i);
            }
        }
        public void stack()
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");
            //stk.Pop();
            //Last in First Out
            foreach (string s in stk)
            {
                Console.Write(s + " ");
            }
        }
        public void queue()
        {
            Queue<string> qr = new Queue<string>();
            qr.Enqueue("bababbbababa");
            qr.Enqueue("123");
            qr.Enqueue("false");
            qr.Enqueue("God");
            //qr.Dequeue();
            //First in First out
            foreach (string s in qr)
            {
                Console.Write(s + " ");
            }
        }
        //non Generic collection
        //Stack  and Queue is same but don't Pass Datatype 
        public void arraylist()
        {
            ArrayList ar = new ArrayList();
            ar.Add(1);
            ar.Add("kevin");
            ar.Add(true);
            ar.Add("Csharp");
            foreach (var i in ar)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------");
            ar.Insert(3, false);
            ar[0] = "lol";
            foreach (var i in ar)
            {
                Console.WriteLine(i);
            }
        }

    }
}
