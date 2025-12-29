using OOPs_Concepts;
using System;

class MAIN
{
    // Entry point must be static
    public static void Main(string[] args)
    {
        //Oops oop = new Oops();
        //oop.NO = 20;
        //Console.WriteLine(oop.NO);
        //oop.age = -2;
        //Console.WriteLine(oop.age);

        //-------------inheritance-----------------
        //Elephant el = new Elephant();
        //el.type();
        //el.Eat(); // using dog class obj to use animal class methods

        //House h = new House();
        //h.PlayerType();

        //pig pg = new pig();
        //pg.sound();
        //------- Polymorphism -------
        //Bird an = new Bird();
        //an.Speak();

        //Shape sp = new Circle();
        //sp.Area();
        //Shape rt = new Rectangle();
        //rt.Area();


        //--------------------Class And Objects------------------------
        //library lb = new library();
        //lb.Book();
        //lb.BorrowBook("baba");
        //lb.BorrowBook("baba");
        //----------------
        //Car car = new Car();
        //car.VehicalInfo("Bmw",250,30);
        //car.refule(20);
        //car.refule(15);
        //car.refule(9);
        //-------------Interface-------------
        //IPayments ipcc = new CreditCardPayment();
        //IPayments upi = new UPIPayment();
        //IPayments cash = new CashPayment();

        //ipcc.ProcessPayment();
        //upi.ProcessPayment();
        //cash.ProcessPayment();
        //---------Encapsulation--------------

        //Bank bk = new Bank();
        //bk.Account(12313211);
        //bk.Deposit(1500);
        //bk.WithdrawMoney(1000);

        Student std = new Student();
        std.StudentInfo("Kevin",1);
        std.addMark(98, 89, 95, 97);
        std.Display();
        std.ClculateAverage();


        //------------enum-------------------

        Day d = Day.Monday;
        Console.WriteLine(d);


        //int d = (int)Day.Monday;//day in  int
        //Console.WriteLine(d);
    }
}


//--------------------------Encapsulation----------------------------------
class Oops
{
    //--------------Automatic Get Set----------------------
    private int age { get; set { if (value >= 0) age = value; } }

    //-----------Manually Get Set --------
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }


    private int no;
    public int NO
    {
        get { return no; }
        set
        {
            if (value >= 0)
                no = value;
        }
    }
}

//----------------inheritance--------------------------
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal eat Food ");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Bhow Bhowww");
    }
}
class Elephant : Animal
{
    public void type()
    {
        Console.WriteLine("Elephant is wild Animal");
    }
}

//-------------------polymorephism----------------------


class Team
{
    public void PlayerType()
    {
        Console.WriteLine("Im Player Of Mumbai ");
    }
}
class Ground : Team
{
    public void PlayerType()
    {
        Console.WriteLine("Im Captain of Mumbai");
    }
}
class House : Team
{
    public void PlayerType()
    {
        Console.WriteLine("Im Fathe of my child");
    }
}

//---------------------abstraction--------------------


//abstract method mandatory to pass all inherited class
//only one abstract method pass 
abstract class animal
{
    public abstract void Sound();
}


class dog : animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog sound Bhow Bhow");
    }
}
class Pig : animal
{
    public override void Sound()
    {
        Console.WriteLine("pig sound wee wee");
    }
}
//----------enum------------------


enum Day
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday
}

