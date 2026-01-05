using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncAwait
{
    internal class MakeTea
    {

        public async Task BoilWater()
        {
            Console.WriteLine("Adding water...");
            await Task.Delay(5000);
            Console.WriteLine("Water boiled");
        }

        public async Task AddTeaLeave()
        {
            Console.WriteLine("Added tea leaves");
            await Task.Delay(2000);
        }

        public async Task AddMilkAndSugar()
        {
            Console.WriteLine("Added milk and sugar");
            await Task.Delay(4000);
        }

        public async Task BoilTea()
        {
            Console.WriteLine("Boiling tea...");
            await Task.Delay(5000);
            Console.WriteLine("Tea Complete ---------");
        }

        public async Task MakeCoffee()
        {
            Console.WriteLine("Make Coffee ");
            await Task.Delay(7000);
            Console.WriteLine("Coffee Complete ---------");
        }


        public async Task<int> sum(int a, int b)
        {
            int sum = a + b;
            return sum ;

        }
    }
}
