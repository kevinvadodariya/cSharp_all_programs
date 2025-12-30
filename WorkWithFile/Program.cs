using System.IO;
using System.Text;
using System.Text.Unicode;

string PATH = "C:/Users/Kevin Patel/source/repos/demo_2/WorkWithFile/Kevin.txt";
//File.WriteAllText(PATH, "Hello");
//Console.WriteLine("File Created");

//File.Delete(PATH);

//File.Copy(PATH, "C:/Users/Kevin Patel/source/repos/demo_2/WorkWithFile/CopyFile.txt");

//Console.WriteLine(File.Exists(PATH));

//string txt = ("This is new text");
//File.AppendAllText(PATH, txt);

////Console.WriteLine (File.ReadAllText(PATH));

//File.Replace("C:/Users/Kevin Patel/source/repos/demo_2/WorkWithFile/CopyFile.txt", PATH, "C:/Users/Kevin Patel/source/repos/demo_2/WorkWithFile/Kevinn.txt");


//---------------StreamWriter-------------
//using (StreamWriter writer = new StreamWriter(PATH))
//{
//    writer.WriteLine("Line 1");
//    writer.WriteLine("Line 2");
//    writer.WriteLine("Last line");
//}

//using (StreamWriter wr=new StreamWriter(PATH, append: true))
//{
//    wr.WriteLine("This is append line");
//}

//using (StreamReader sr = new StreamReader(PATH))
//{
//    string line;
//    while ((line = sr.ReadLine()) != null)
//    {
//        Console.WriteLine(line);
//    }

//}

//using (FileStream fs=new FileStream(PATH, FileMode.Open, FileAccess.Read, FileShare.Read)
//{

//})
//{
//    Console.WriteLine();
//}

//--------------------Try Catch Finally--------------------------------

//try
//{
//    int no = 5;
//    if (no > 0)
//    {
//        string name = "baba";
//        //string name = '123';
//        no = int.Parse(name);
//        Console.WriteLine(no);
//    }
//}
//catch (Exception e)

//{
//    Console.WriteLine(e.Message);
//}
//finally
//{
//    Console.WriteLine("Im always Executes");
//}
//------------------Throw Keyword-------------------------

//int age = 10;
//if (age < 18)
//{
//    throw new ArithmeticException("Access Denied");

//}
//else
//{
//    Console.WriteLine("Access Granted");
//}

//----------------------MUL. CATCH-----------------------------
try{Console.WriteLine("Enter No ");
int no = int.Parse(Console.ReadLine());

int result = 100 / no;
    Console.WriteLine("Result " + result);
}catch(FormatException e)
{
    Console.WriteLine("Format sahi nai hai :-"+e);
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("Divide by zero :"+ex);
}
catch (OverflowException ex)
{
    Console.WriteLine("Over Flow"+ex);
}
catch (InvalidCastException ex )
{
    Console.WriteLine("Invalid cast"+ex);
}