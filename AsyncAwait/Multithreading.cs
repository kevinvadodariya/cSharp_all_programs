using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncAwait
{
    internal class Multithreading
    {

        public void BoilWater()
        {
            Console.WriteLine("Boiling water...");
            Thread.Sleep(5000); 
            Console.WriteLine("Water boiled");
        }

        public void MakeTea()
        {
            Console.WriteLine("Added Tea Leave....");
            Console.WriteLine("Add Milk");
            Thread.Sleep(5000);
            Console.WriteLine("Ready.....!!");
        }

        public void PrepareCup()
        {
            Console.WriteLine("Preparing cup...");
            Thread.Sleep(2000); 
            Console.WriteLine("Cup ready");
        }

        public void ServeTea()
        {
            Console.WriteLine("Tea is ready to serve ☕");
        }
    }
}
