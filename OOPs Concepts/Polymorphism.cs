using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs_Concepts
{
    internal class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Animal Speaks");
        }
    }
    class Dog : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Dog Say :Bhow Bhow");
        }
    }
    class Cat : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Cat Say :Mew Mew");
        }
    }
    class Bird : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Bird Say :Chi chi");
        }
    }
}


class Shape
{
    public virtual void Area()
    {
        Console.WriteLine("Find Area Of Shape");
    }//use virtual key word for method override


}
class Circle : Shape
{
    public override void Area()
    {
        Console.WriteLine("Enter Radius :");
        double radius = double.Parse(Console.ReadLine());
        double Area = 3.14159 * radius * radius;
        Console.WriteLine("Area Of circle " + Area);
    }//use override keyword
}
class Rectangle : Shape
{
    public override void Area()
    {
        Console.WriteLine("Enter Length:");
        double length = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Breadth :");
        double breadth = double.Parse(Console.ReadLine());

        double area = length * breadth;
        Console.WriteLine("Area Of Rectangle " + area);
    }
}
class Triangle:Shape
{
    public override void Area()
    {
        Console.WriteLine("Enter Base :");
        double Base = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Height :");
        double Height = double.Parse(Console.ReadLine());
        double area = 0.5 * Height*Base;
        Console.WriteLine("Area Of Triangle " + area);
    }
}