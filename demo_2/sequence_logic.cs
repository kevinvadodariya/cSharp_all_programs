using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
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


        public void distance()
        {
            Console.WriteLine("Enter Distance between two cities(in KM) :");
            double dis = Convert.ToDouble(Console.ReadLine());
            double meter = dis * 1000;
            double feet = meter * 3.28084;
            double inch = meter * 39.3701;
            double cm = meter * 100;
            double yard = meter * 1.09361;
            Console.WriteLine($"{dis}km distance in meter :{meter}, feet : {feet} ,inch : {inch},cm : {cm} ,yard :{yard}");

        }

        public void area_of_shapes()
        {
            //-----circle
            //Console.WriteLine("Enter radius of circul :");
            //double r = Convert.ToDouble(Console.ReadLine());

            //double areaOfcircle=3.14159*r*r;
            //Console.WriteLine($"area of circle is :{areaOfcircle}");
            //--------rectangle
            //Console.WriteLine("Enter length :");
            //double l = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter width :");
            //double w = Convert.ToDouble(Console.ReadLine());
            //double areaOfrectangle  =  l* w;
            //Console.WriteLine($"area of rectangle is :{areaOfrectangle}");

            //-----square
            //Console.WriteLine("Enter length :");
            //double l_square = Convert.ToDouble(Console.ReadLine());

            //double area = l_square * l_square;
            //Console.WriteLine($"area of square is :{area}");

            //-------triangle
            //Console.WriteLine("Enter base of triangle :");
            //double T_base = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter height :");
            //double T_height = Convert.ToDouble(Console.ReadLine());


            //double area = 0.5 * (T_base * T_height);
            //Console.WriteLine($"area of square is :{area}");
            //-------Parallelogram
            Console.WriteLine("Enter base of Parallelogram  :");
            double T_base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of Parallelogram :");
            double T_height = Convert.ToDouble(Console.ReadLine());


            double area = T_base * T_height;
            Console.WriteLine($"area of square is :{area}");
        }

        public void volume()
        {
            //-----cylinder
            //Console.WriteLine("Enter radius:");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter height :");
            //double height = Convert.ToDouble(Console.ReadLine());
            //double volume = 3.14159*(radius * radius)*height;
            //Console.WriteLine($"volume of cylinder is :{volume}");


            //--------cone
            //Console.WriteLine("Enter radius:");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter height :");
            //double height = Convert.ToDouble(Console.ReadLine());


            //double volume = 3.14159 * (radius * radius) * (height/3);
            //Console.WriteLine($"volume of cylinder is :{volume}");

            //--------ractangle
            //Console.WriteLine("Enter length:");
            //double length = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter width :");
            //double width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter height :");
            //double height = Convert.ToDouble(Console.ReadLine());


            //double volume = length * width * height;
            //Console.WriteLine($"volume of cylinder is :{volume}");
            //--------cube
            Console.WriteLine("Enter edge :");
            double edge = Convert.ToDouble(Console.ReadLine());

            double volume = edge * edge * edge;
            Console.WriteLine($"volume of cylinder is :{volume}");

        }


        public void parimeter()
        {

            //====circle====
            //Console.WriteLine("Enter Radius of circle : ");
            //double radius = double.Parse(Console.ReadLine());

            //double parimeter = 2 * 3.14159 * radius;
            //Console.WriteLine($"parimeter of circle is :{parimeter}");

            //======ractangle=====
            //Console.WriteLine("Enter length of ractangle : ");
            //double length = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter width of ractangle : ");
            //double width = double.Parse(Console.ReadLine());

            //double parimeter = 2 *(length+width);
            //Console.WriteLine($"parimeter of circle is :{parimeter}");
            //=======squar========
            Console.WriteLine("Enter area of squar : ");
            double area = double.Parse(Console.ReadLine());
            double squar_parimeter = 4 * area;
            Console.WriteLine($"parimeter of squar is :{squar_parimeter}");
        }

        public void leapYear()
        {
            Console.WriteLine("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

            string Result= (year % 4 == 0 && year%400==0 || year%100==0)? "leap year": "not leap year";
            Console.WriteLine(Result);
        }
    }
}
