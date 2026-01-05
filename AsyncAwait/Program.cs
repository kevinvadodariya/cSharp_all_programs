using AsyncAwait;
using System.Threading;
// See https://aka.ms/new-console-template for more information



public class async1
{
    static async Task Main(string[] args)
    {
        // asyncPrograms asp = new asyncPrograms();
        //Task task1= WashAndDryCloth();
        // Task task2 = asp.CookFood();
        // await Task.WhenAll(task1,task2);
        // Console.WriteLine("Task Complete --------");

        //Task task1= waitSometime();
        //Task task2= after();

        // await Task.WhenAll(task1, task2);

        //=================Make Tea====================

        //MakeTea mt = new MakeTea();
        //Task task1 = Maketea();
        //Task task2 = mt.MakeCoffee();
        //Console.WriteLine(mt.sum(2, 5).Result);

        //await Task.WhenAll(task1, task2);
        //Console.WriteLine("ready to serve Tea And Coffee");

        //============Multithreading==============

        Multithreading mit = new Multithreading();
        Thread thread1 = new Thread(mit.BoilWater);
        Thread thread2 = new Thread(mit.PrepareCup);
        Thread thread3 = new Thread(mit.MakeTea);
        thread1.Start();
        thread2.Start();
        

        thread1.Join();
        thread3.Start();
        thread2.Join();
        thread3.Join();

        mit.ServeTea();
    }

    private static async Task Maketea()
    {
        MakeTea mt = new MakeTea();
        await mt.BoilWater();
        await mt.AddTeaLeave();
        await mt.AddMilkAndSugar();
        await mt.BoilTea();
    }
    private static async Task WashAndDryCloth()
    {
        asyncPrograms asp = new asyncPrograms();
        await asp.WashClothes();
        await asp.DryClothes("T-Shirt");
    }
    static async Task waitSometime()
    {
        Console.WriteLine("--wait func start");
        await Task.Delay(6000);
        Console.WriteLine("--Over");

    }
    static async Task after()
    {
        Console.WriteLine("--after start");
        //await Task.Delay(6000);
        Console.WriteLine("--after over");

    }

}