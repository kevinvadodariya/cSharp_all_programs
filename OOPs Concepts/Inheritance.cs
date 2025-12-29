using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace OOPs_Concepts
{
    internal class Inheritance
    {
        string b_title;
        string b_author;
        bool b_Astatus;

        public void Book()
        {
            Console.WriteLine("Enter Book Name");
            b_title = Console.ReadLine();
            Console.WriteLine("Enter Book Author Name");
            b_author = Console.ReadLine();
            b_Astatus = true;
            Console.WriteLine("Book Added");
        }

        public void BorrowBook(string bookname)
        {
            if (bookname == b_title && b_Astatus == true)
            {

                b_Astatus = false;
                Console.WriteLine("Thank you for get book");

            }
            else
            {
                Console.WriteLine("Book Not Available");
            }
        }
        public void ReturnBook()
        {
            b_Astatus = true;
        }
    }

    class VehicleManagament
    {
        int Speed;
        protected int Fuel;
        protected int FuelCap;
        public void VehicalInfo(string nameVehicle, int speed, int fuelcapacity)
        {
            FuelCap = fuelcapacity;
            Console.WriteLine("vehical Name : " + nameVehicle + " Speed (kmp/h) " + speed + " Fuel Capacity(Liter) " + fuelcapacity);

        }

        public void refule(int fuel)
        {
            int remainFuel = FuelCap - Fuel;

            if (FuelCap == Fuel)
            {
                Console.WriteLine("Tank Is full");

            }
            else
            {
                if (fuel <= remainFuel)
                {
                    Fuel += fuel;
                    Console.WriteLine(fuel + "(Liter) Fuel Added");
                    Console.WriteLine("Remain Space (Liter)" + (remainFuel - fuel));
                    Console.WriteLine("----------------");

                }
                else
                {
                    Console.WriteLine("Capacity Overload with " + (fuel - remainFuel) + " Liter");
                    Console.WriteLine("Add Fuel " + remainFuel + " Liter or Less");
                }

            }
        }
    }
    class Car : VehicleManagament
    {

        public void ExtraFeat()
        {
            Console.WriteLine("Car Have 4 Door ");

        }
        

    }
    class Bike : VehicleManagament
    {
        public void ExtraFeat()
        {
            Console.WriteLine("gera and with out gear");

        }
    }
    class Truck : VehicleManagament
    {
        public void ExtraFeat()
        {
            Console.WriteLine("Load Cargo ");

        }
    }
}
