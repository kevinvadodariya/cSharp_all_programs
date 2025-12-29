using System.IO;

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
   
using (StreamReader sr=new StreamReader(PATH))
{
    Console.WriteLine(sr.ReadLine());
}
                                                                               