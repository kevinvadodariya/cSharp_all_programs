using System;
using System.Collections.Generic;
using System.Text;

namespace demo_2
{
    internal class sequence_logic
    {

        public void Simple_interest()
        {
            Console.WriteLine("Enter Amount :");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("No of Years :");
            int P_no_year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate of interest(per annum) :");
            int rate_of_interest = int.Parse(Console.ReadLine());

            int si = (amount * P_no_year * rate_of_interest / 100);
            Console.WriteLine(si);
        }
        public void compound_interest()
        {
            Console.WriteLine("Enter Amount :");
            double amount = int.Parse(Console.ReadLine());
            Console.WriteLine("No of Years :");
            double P_no_year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate of interest(per annum) :");
            double rate_of_interest = int.Parse(Console.ReadLine());

            double ci = amount * Math.Pow((1 + rate_of_interest / 100), P_no_year);
            double interest = ci - amount;
            Console.WriteLine(interest);

        }
        public void cel_fer()
        {
            Console.WriteLine("Enter Celsius :");
            double cel = Convert.ToDouble(Console.ReadLine());

            double fer = (cel * 1.8) + 32;



            Console.WriteLine("Fahrenheit is :", fer);
        }
    }
}
