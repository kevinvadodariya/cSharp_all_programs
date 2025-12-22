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
        public void char_wovels()
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
                    Console.WriteLine(char1 + " :- Vovels");
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

        public void expenses()
        {
            Console.WriteLine("Enter Your Total Income :");
            double income = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your expenses amount :");
            double expenses = double.Parse(Console.ReadLine());


            double saving = income - expenses;

            Console.WriteLine(" Your saving amount is :" + saving);


        }

        public void iceCreamChoice()
        {
            Console.WriteLine("Available Ice Creams:");
            Console.WriteLine("American Nuts");
            Console.WriteLine("Vanila");
            Console.WriteLine("Chocolate");
            Console.WriteLine("Dry Fruits");
            Console.WriteLine("Whice Ice Cream Do You like? : ");
            string userChoice = Console.ReadLine().ToUpper().Trim();
            if (userChoice == "AMERICAN NUTS")
            {
                Console.Write("Thank You for Buy AMERICAN NUTS Ice-cream ");
            }
            else if (userChoice == "VANILA")
            {
                Console.Write("Thank You for Buy VANILA Ice-cream");
            }
            else if (userChoice == "CHOCOLATE")
            {
                Console.Write("Thank You for Buy CHOCOLATE Ice-cream");
            }
            else if (userChoice == "DRY FRUITS")
            {
                Console.Write("Thank You for Buy DRY FRUITS Ice-cream");
            }
            else
            {
                Console.Write("Enter Valid Type of Ice-cream");
            }
        }


        public void age()
        {
            Console.Write("Enter Your Age : ");
            int age = int.Parse(Console.ReadLine());
            if (age == 0 && age <= 2)
            {
                Console.WriteLine("Still Baby");
            }
            else if (age >= 3 && age <= 12)
            {
                Console.WriteLine("Children");
            }
            else if (age >= 13 && age <= 17)
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 18 && age <= 26)
            {
                Console.WriteLine("Young Adult");
            }
            else if (age >= 27 && age <= 39)
            {
                Console.WriteLine("Middle age");
            }
            else if (age >= 40 && age <= 79)
            {
                Console.WriteLine("Grand Perents");
            }
            else if (age == 80 || age > 80)
            {
                Console.WriteLine("Wow");
            }
            else
            {
                Console.WriteLine("Enter Valid Age");
            }
        }

        public void arithmetic()
        {
            Console.WriteLine("Enter No 1 :");
            double no1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter No 2 :");
            double no2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please choose below any one operation!!");

            Console.WriteLine("Addition (+)");
            Console.WriteLine("Subtraction (-)");
            Console.WriteLine("Multiplication (*)");
            Console.WriteLine("Division (/)");
            Console.WriteLine("Reminder (%)");
            char user_input = Console.ReadKey().KeyChar;
            double ans = 0;
            if (user_input == '+')
            {
                ans = no1 + no2;
            }
            else if (user_input == '-')
            {
                ans = no1 - no2;
            }
            else if (user_input == '*')
            {
                ans = no1 * no2;
            }
            else if (user_input == '/')
            {
                ans = no1 / no2;
            }
            else if (user_input == '%')
            {
                ans = no1 % no2;
            }
            else
            {
                Console.Write("Enter valid input");
            }
            Console.WriteLine("Your Ans Is :" + ans);

        }

        public void intrestCalculation()
        {
            Console.WriteLine("Enter Amount :");
            double principalAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter How Many Time (inMonth) :");
            int period = int.Parse(Console.ReadLine());
            double intrestRate = 0;

            if (period < 3)
            {
                intrestRate = 4;
            }
            else if (period >= 3 && period <= 11)
            {
                intrestRate = 4.5;
            }
            else if (period >= 12 && period <= 23)
            {
                intrestRate = 5;
            }
            else if (period >= 24 && period <= 35)
            {
                intrestRate = 5.5;
            }
            else if (period >= 36 && period <= 59)
            {
                intrestRate = 6;
            }
            else if (period >= 60)
            {
                intrestRate = 6.5;
            }
            else
            {
                Console.WriteLine("Enter Valid Details");
            }

            double si = (period / 12) * intrestRate * principalAmount / 100;
            double ciAmount = principalAmount * Math.Pow((1 + intrestRate / 100), (period / 12));
            double ci = ciAmount - principalAmount;
            Console.WriteLine("\n----- Interest Details -----");
            Console.WriteLine("Your Amount :" + principalAmount);
            Console.WriteLine($"Your Time Period :{period} Months");
            Console.WriteLine($"Your Interest Rate :{intrestRate} %");
            Console.WriteLine("Simple Interest :" + si);
            Console.WriteLine("Compound Interest :" + ci);
            Console.WriteLine("Total Amount  :" + (((int)principalAmount) + ((int)ci)));

        }
        public void identifyChar()
        {
            Console.WriteLine("Enter Charecter :");
            char ch = Console.ReadKey().KeyChar;
            if (char.IsDigit(ch))
            {
                Console.WriteLine("\nCharecter is Digit ");
            }
            else if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("\nCharecter is Vowels");
            }
            else if (char.IsLetter(ch))
            {
                Console.WriteLine("\nCharecter is Consonant");
            }
            else
            {
                Console.WriteLine("\nCharecter is Special Symbols");
            }
        }
    }
}
