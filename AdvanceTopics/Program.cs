// See https://aka.ms/new-console-template for more information
using AdvanceTopics;

//------Collection----------
collection cn = new collection();
//cn.list();
//cn.Dictionary();
//cn.arraylist();
//cn.stack();
//cn.queue();
//---------Generics-------------
//GenericsStore<string, int> gs = new GenericsStore<string, int>();
//gs.AddProduct("Book", 1);
//gs.GetAllProduct();
//==========================Delegates=====================
//Delegates delObj = new Delegates();
//pass delegate inside of class
//Delegates.mydel d = delObj.Sum;

// //outside of class
//mydel d = delObj.Sum;
//d(5, 23);
//------------Static Method----------------
//strdel std = Delegates.Say;

//-----------Non Static method--------------
//strdel std = delObj.Say;
//Console.WriteLine(std("kevin"));

//---------------Anonymous function---------------------------
//strdel ss = delegate (string s) { Console.WriteLine("hhhhhh"); return s; };


//--------------Func ----------------------
//Func<int,int,int> sum = Delegates.add;//first 2 int is input type and 3 is output type
//Console.WriteLine(sum(1,5));


//-------------Action--------------------

//Action<int, int> act = delObj.Sum;//only input type add between<>
//act(1, 6);

//==============Events==============================


Bell bl = new Bell();
//Student st = new Student();
bl.ringed += bl.MakeStudentsStandUp;
bl.standup += bl.ReadyForSchool;
bl.Ring();

RingedDelegate rd = bl.Ring; //using delegate directly 
rd += bl.ReadyForSchool; //if ring method execute so event fire and execute anothor method
rd();