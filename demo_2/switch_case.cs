using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace demo_2
{
    internal class switch_case
    {
        public void switch1()
        {
            Console.WriteLine("Enter Your Choice(in number)");
            int no = int.Parse(Console.ReadLine());
            switch (no)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("invalis choice");
                    break;
            }

        }
        public void switch2()
        {
            Console.WriteLine("Enter NO 1");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter NO 2");
            int no2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your choice (+ - * /)");
            char symbol = Console.ReadKey().KeyChar;
            switch (symbol)
            {
                case '+':
                    Console.WriteLine(no1 + no2);
                    break;
                case '-':
                    Console.WriteLine(no1 - no2);
                    break;
                case '*':
                    Console.WriteLine(no1 * no2);
                    break;
                case '/':
                    Console.WriteLine(no1 / no2);
                    break;

            }

        }
    }
}
