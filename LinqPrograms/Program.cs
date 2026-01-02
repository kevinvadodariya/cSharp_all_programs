

using LinqPrograms;
SelectMethod sm = new SelectMethod();
sm.add();
//sm.select();
//sm.Orderby();
//sm.Where();
//sm.SelectSpecificElement();
//sm.GroupBy();
//sm.Aggregate();
//sm.SetOperation();
sm.RangeRepeatRevers();


//Order or = new Order();
//or.add();
//or.aggregate();

//==============================Join===========================


//Student st = new Student();
//st.Add();
//Course cs = new Course();
//cs.Add();

//---------inner join----
//var data = st.students.Join(cs.courses,
//                            st => st.Id,
//                            cs => cs.StudentId,
//                            (st, cs) => new { st.Name, cs.CourseName });
//foreach (var item in data)
//{
//    Console.WriteLine($"{item.Name} - {item.CourseName}");
//}
//----------Group join--------------

//var data = st.students.GroupJoin(cs.courses,
//                            st => st.Id,
//                            cs => cs.StudentId,

//                            (st, CourseGroup) => new { 
//                               StudentName= st.Name,
//                                Course=CourseGroup
//                            });
//foreach (var item in data)
//{
//    Console.WriteLine(item.StudentName);
//    foreach (var item1 in item.Course)
//    {
//        Console.WriteLine( string.Join(',', item1.CourseName));
//    }
//    Console.WriteLine();

//}
//------------------Left Join---------------------

//var data = st.students.LeftJoin(cs.courses, s => s.Id, c => c.StudentId, (s, c) => new
//{
//    StudentName = s.Name,
//    Course = c?.CourseName ?? "Empty"
//});

//foreach (var item in data)
//{
//    Console.WriteLine("Student Name :" + item.StudentName + "   `Course Name: " + item.Course);

//}
//------------------Right Join------------------------------

//var data = st.students.RightJoin(cs.courses, s => s.Id, c => c.StudentId, (s, c) => new { 
//    Name=s?.Name??"No Student",
//    Course=c.CourseName
//});
//foreach (var item in data)
//{
//    Console.WriteLine(item.Name+" "+item.Course);
//}

//====================Simple Syntax=================================
//emp.ForEach(e => Console.WriteLine(e.EmpFirstName));

//------------Using For Each loop---------------
//foreach(var j in emp)
//{
//    Console.WriteLine(j.Id+j.EmpFirstName+j.EmpFirstName);
//}

