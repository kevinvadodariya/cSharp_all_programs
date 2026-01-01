

using LinqPrograms;



//Employee employee = new Employee();
//employee.AddDetails( 1,  "Ali",  "Khan",  "IT",  22,  30000);
//employee.AddDetails(2, "Sara", "Ahmed", "HR", 25, 28000);
//employee.AddDetails(3, "John", "Smith", "Finance", 30, 40000);
//employee.AddDetails(5, "Neha", "Verma", "It", 28, 25000);
//employee.AddDetails(4, "Aman", "Verma", "IT", 28, 35000);
//employee.AddDetails(5, "Neha", "Sharma", "Admin", 26, 25000);
//employee.getData();

SelectMethod sm = new SelectMethod();
sm.add();
//sm.select();
//sm.Orderby();
//sm.Where();
//sm.SelectSpecificElement();
sm.GroupBy();



class Employee
{
    public int Id { get; set; }
    public string EmpFirstName { get; set; }
    public string EmpLastName { get; set; }
    public string Department { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }

    List<Employee> emp = new List<Employee>();
    

    public void AddDetails(int id, string firstname, string lastname, string depart, int age, int salary)
    {
        emp.Add(new Employee
        {
            Id = id,
            EmpFirstName = firstname,
            EmpLastName = lastname,
            Department = depart,
            Age = age,
            Salary = salary,
        });
    }
    public void getData()
    {
        emp.GetEnumerator();
        
        //----------------Using LINQ--------------------------

        IEnumerable<string> names = emp.Select(e => e.EmpFirstName).Distinct();//remove duplicate value use .Distinct()
        //foreach (var item in names)
        //{
        //    Console.WriteLine(item);
        //}

        //var name=emp.Where(e => e.Id == 3).Select(e => e.EmpFirstName);   //Using Where 
        //foreach (var n in name)
        //{
        //    Console.WriteLine(n);
        //}
       

        //====================Simple Syntax=================================
        //emp.ForEach(e => Console.WriteLine(e.EmpFirstName));

        //------------Using For Each loop---------------
        //foreach(var j in emp)
        //{
        //    Console.WriteLine(j.Id+j.EmpFirstName+j.EmpFirstName);
        //}
    }
}