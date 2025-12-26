class main
{
    static void Main(string[] args)
    {
        //Oops oop = new Oops();
        //oop.NO = 20;
        //Console.WriteLine(oop.NO);
        //oop.age = -2;
        //Console.WriteLine(oop.age);

        //-------------inheritance-----------------
        //Elephant el = new Elephant();
        //el.type();
        //el.Eat();//using dog class obj to use animal class methosd

        House h = new House();
        h.PlayerType();

    }


}
class Oops
{
    //--------------Automatic Get Set----------------------
    public int age { get; set { if (value >= 0) age = value; } }

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


    //public void encapsulation()
    //{

    //}
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