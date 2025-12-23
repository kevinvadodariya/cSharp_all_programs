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

            Console.WriteLine("Enter your choice (+ - * / % any One)");
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
                case '%':
                    Console.WriteLine(no1 % no2);
                    break;

            }

        }
        public void iceCream()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Available Ice Creams:");
            Console.WriteLine("=======================================");
            Console.WriteLine("American Nuts");
            Console.WriteLine("Vanila");
            Console.WriteLine("Chocolate");
            Console.WriteLine("Dry Fruits");
            Console.WriteLine("=======================================");
            Console.WriteLine("Whice Ice Cream Do You like? : ");

            string userChoice = Console.ReadLine().ToUpper().Trim();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("             Price      ");
            Console.WriteLine("\nSmall      Medium      Large");
            Console.WriteLine("=======================================");
            switch (userChoice)
            {
                case "AMERICAN NUTS":

                    Console.WriteLine("\n30         60          85");
                    Console.WriteLine("\nThank You !!!");
                    break;
                case "VANILA":
                    Console.WriteLine("\n20         40          60");
                    Console.WriteLine("\nThank You !!!");
                    break;
                case "CHOCOLATE":
                    Console.WriteLine("\n35         65          90");
                    Console.WriteLine("\nThank You !!!");
                    break;
                case "DRY FRUITS":
                    Console.WriteLine("\n30         55          80");
                    Console.WriteLine("\nThank You !!!");
                    break;
                default:
                    Console.WriteLine("Enter Valid Ice-cream Type \n Thank You!");
                    break;
            }
        }
        public void identifyChar()
        {
            Console.WriteLine("Enter Any Character :");
            char ch = Console.ReadKey().KeyChar;

            switch (ch)
            {
                //case char c when ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u':
                //    Console.WriteLine("Your Charechter" + ch + "is Vowels");
                //    break;
                case char c when "aeiouAEIOU".Contains(ch):
                    Console.WriteLine("\nYour Charechter " + ch + " is Vowels");
                    break;
                case char c when char.IsDigit(ch):
                    Console.WriteLine("\nYour Charechter " + ch + " is Digit");
                    break;
                case char c when char.IsLetter(ch):
                    Console.WriteLine("\nYour Charechter " + ch + " is Consonant");
                    break;
                default:
                    Console.WriteLine("\nYour Charechter " + ch + " is Special Symbol");
                    break;
            }
        }

    }
}
