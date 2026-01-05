using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncAwait
{
    internal class asyncPrograms
    {
        public async Task WashClothes()
        {
            Console.WriteLine("--Start Washing");
            await Task.Delay(6000);
            Console.WriteLine("--Washing Complete");
        }

        public async Task DryClothes(string clothes)
        {
            Console.WriteLine("--Start Drying");
            await Task.Delay(3000);
            Console.WriteLine("--Dry Complete");
        }

        public async Task CookFood()
        {
            Console.WriteLine("--Start Cooking");
            await Task.Delay(4000);
            Console.WriteLine("--Cooking Complete");
        }
        
    }
}
