using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPrograms
{
    internal class SelectMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Hobby { get; set; }
        public List<string> Skills { get; set; }
        public int Salary { get; set; }

        List<SelectMethod> listnum = new List<SelectMethod>();//Create List
        public void add()
        {
            listnum.Add(new SelectMethod
            {
                Id = 1,
                Name = "Kevin",
                Salary = 30000,
                Hobby = new List<string> { "Football", "Chess" },
                Skills = new List<string> { "C#", "SQL", "Communication" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 2,
                Name = "Prince",
                Salary = 28000,
                Hobby = new List<string> { "Reading", "Music" },
                Skills = new List<string> { "Java", "Communication", "Problem Solving" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 3,
                Name = "Bob",
                Salary = 32000,
                Hobby = new List<string> { "Cricket" },
                Skills = new List<string> { "Python", "Problem Solving", "Teamwork" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 4,
                Name = "Prince",
                Salary = 35000,
                Hobby = new List<string> { "Chess" },
                Skills = new List<string> { "C++", "Teamwork", "SQL" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 5,
                Name = "David",
                Salary = 40000,
                Hobby = new List<string> { "Gym", "Running" },
                Skills = new List<string> { "Project Management", "Excel", "Communication" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 6,
                Name = "Emma",
                Salary = 2000,
                Hobby = new List<string> { "Painting" },
                Skills = new List<string> { "Photography", "Creativity", "Problem Solving" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 7,
                Name = "Frank",
                Salary = 36000,
                Hobby = new List<string> { "Photography", "Travel" },
                Skills = new List<string> { "Photography", "Social Media", "C#" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 8,
                Name = "Grace",
                Salary = 29000,
                Hobby = new List<string> { "Cooking" },
                Skills = new List<string> { "Culinary Arts", "Nutrition", "Teamwork" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 9,
                Name = "Henry",
                Salary = 31000,
                Hobby = new List<string> { "Swimming" },
                Skills = new List<string> { "Time Management", "Data Analysis", "Excel" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 10,
                Name = "Mia",
                Salary = 32000,
                Hobby = new List<string> { "Yoga", "Meditation" },
                Skills = new List<string> { "Mindfulness", "Public Speaking", "Problem Solving" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 11,
                Name = "Sara",
                Salary = 30000,
                Hobby = new List<string> { "Gaming" },
                Skills = new List<string> { "C#", "Problem Solving", "Teamwork" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 12,
                Name = "Karen",
                Salary = 26000,
                Hobby = new List<string> { "Blogging" },
                Skills = new List<string> { "Writing", "SEO", "Communication" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 13,
                Name = "Leo",
                Salary = 45000,
                Hobby = new List<string> { "Investing", "Reading" },
                Skills = new List<string> { "Finance", "Analytics", "Excel" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 14,
                Name = "Mia",
                Salary = 31000,
                Hobby = new List<string> { "Dancing" },
                Skills = new List<string> { "Choreography", "Performance", "Teamwork" }
            });

            listnum.Add(new SelectMethod
            {
                Id = 15,
                Name = "Noah",
                Salary = 34000,
                Hobby = new List<string> { "Cycling", "Hiking" },
                Skills = new List<string> { "Photography", "Endurance", "Problem Solving" }
            });


        }

        public void select()
        {
            //use for select perticular fields like name id salary etc
            IEnumerable<string> name = listnum.Select(n => n.Name); // single field
            IEnumerable<string> hobby = listnum.SelectMany(p => p.Hobby);//Selectmany
            var name2 = listnum.Select(n => new { n.Name, n.Id });// lambda expression returns an object with a new anonymous type with two properties
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            //listnum.ForEach(n => Console.WriteLine("ID :" + n.Id + " Name : " + n.Name));

            //==========Get Skills from list================
            var data = listnum.Select(n => n);
            foreach (var item in data)
            {
                Console.WriteLine("Name :   " + item.Name + "   Skills : " + string.Join(',', item.Skills));
            }

        }
        public void Orderby()
        {
            var name = listnum.OrderBy(v => v.Name);//ascending
            var namedesc = listnum.OrderByDescending(v => v.Name);//descending

            var Thenby = listnum.OrderBy(n => n.Name).ThenBy(s => s.Salary);//first sort by name if same name in data than sort same data from salary
            //var Thenby = listnum.OrderBy(n => n.Name).ThenByDescending(s => s.Salary);//Thenby descending
            foreach (var n in Thenby) { Console.WriteLine("ID :" + n.Id + " Name : " + n.Name + " Salary:" + n.Salary); }
        }
        public void Where()
        {
            //var find=listnum.Where(n => n.Id <= 2 && n.Name.ToLower().StartsWith("k"));
            //foreach (var item in find)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //==============First=================
            //var first = listnum.First();
            //var last = listnum.Last();
            //Console.WriteLine(first.Name);

            var firstdefault = listnum.FirstOrDefault(n => n.Name == "Crimson");
            var lastdeafult = listnum.LastOrDefault(n => n.Name == "Kezdxvin");
            var single = listnum.SingleOrDefault(e => e.Name == "kevin");// ^ as a same of above 
            if (firstdefault != null)
            {
                Console.WriteLine(firstdefault.Name);
            }
            else
            {
                Console.WriteLine("No availabel");
            }
        }

        public void SelectSpecificElement()
        {
            //var data = listnum.Select(n => n.Salary).Distinct();
            //var data = listnum.DistinctBy(n=>n.Salary);

            //var data = listnum.Take(5);
            //var data = listnum.Skip(5);
            //var data = listnum.Skip(2).Take(5);


            //var data = listnum.TakeWhile(n => n.Name != "David");
            var data = listnum.SkipWhile(n => n.Name != "David");
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " Name :" + item.Name + "  Salary : " + item.Salary);
            }

            //================any all contains===========================
            //var data = listnum.All(s => s.Salary > 40000);//only all element setisfy condition
            //var data = listnum.Any(s => s.Salary > 40000);//only one element setisfy condition
            //Console.WriteLine(data);
            //var data = listnum.Select(a => a.Name);
            //var exist = data.Contains("David");//return only true false
            //if (exist)
            //{
            //    Console.WriteLine(exist);
            //}
            //else
            //{
            //    Console.WriteLine("noooooo");
            //}
        }
        public void GroupBy()
        {
            //One key in Groupby
            //var data = listnum.GroupBy(a => a.Skills[0]);
            //foreach (var item in data)
            //{
            //    Console.WriteLine("Skills: "+item.Key);
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine("Id :-"+item1.Id+" "+item1.Name);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("--------");
            //}
            //More than One Key 
            var data = listnum.GroupBy(k => k.Salary, a => a.Name);
            foreach (var item in data)
            {
                Console.WriteLine("Name: " + item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine("Skills :-" + item1);
                }
                Console.WriteLine();
                Console.WriteLine("--------");
            }
        }
        public void Aggregate()
        {
            int count = listnum.Count(n => n.Name == "Mia" && n.Id > 10);
            int sum = listnum.Sum(s => s.Salary);

            int min = listnum.Min(s => s.Salary);//Only give min salary
            var minby = listnum.MinBy(s => s.Salary);//return all propery of min salary record

            int max = listnum.Max(s => s.Salary);//Only give Max salary
            var maxby = listnum.MaxBy(s => s.Salary);//return all propery of Max salary record
            Console.WriteLine(minby.Name + " " + maxby.Salary);

            double avg = listnum.Average(a => a.Salary);
            //Console.WriteLine("Average Salary : "+ (int)avg);

        }
        public void SetOperation()
        {
            var no1 = new[] { 1, 2, 3, 4, 5 };
            var no2 = new[] { 3, 4, 5, 6, 7 };
            var people1 = new[] { new { Name = "John" }, new { Name = "Sara" } };
            var people2 = new[] { new { Name = "Sara" }, new { Name = "Mike" }, new { Name = "Kevin" } };

            bool s = no1.SequenceEqual(no2);
            Console.WriteLine(s);

            var noI = no1.Union(no2);   //union
            var noU = no1.Intersect(no2);   //intersect
            //Console.WriteLine(string.Join(",", noU));

            var uniBy = people1.UnionBy(people2, p => p.Name);
            var InteBy = listnum.IntersectBy(people2.Select(p => p.Name), k => k.Name);

            //foreach (var item in InteBy)
            //{
            //    Console.WriteLine(string.Join(",",item.Name));
            //}


            var exc = no1.Except(no2);
            foreach (var item in exc)
            {
                Console.WriteLine(item);
            }

            var excBy = people1.ExceptBy(people2.Select(p=>p.Name),p=>p.Name);
            foreach (var item in excBy)
            {
                Console.WriteLine(string.Join(",", item.Name));
            }
        }
        public void RangeRepeatRevers()
        {
            var range = Enumerable.Range(1, 10);
            foreach (var item in range)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            var repeat = Enumerable.Repeat('k', 10);
            foreach (var item in repeat)
            {
                Console.WriteLine(item);
            }

            var revers = range.Reverse();
            foreach (var item in revers)
            {
                Console.Write(item+" ");
            }
        }
    }
}

class Order
{
    public int OrderNO { get; set; }
    public string ProductName { get; set; }
    public int Quntity { get; set; }
    public Double Price { get; set; }
    public double Total;

    List<Order> orders = new List<Order>();

    public void add()
    {
        orders.Add(new Order { OrderNO = 1, ProductName = "Laptop", Quntity = 2, Price = 50000.0 });
        orders.Add(new Order { OrderNO = 2, ProductName = "Mouse", Quntity = 5, Price = 500.0 });
        orders.Add(new Order { OrderNO = 3, ProductName = "Keyboard", Quntity = 3, Price = 1000.0 });
        orders.Add(new Order { OrderNO = 4, ProductName = "Monitor", Quntity = 2, Price = 10000.0 });
        orders.Add(new Order { OrderNO = 5, ProductName = "Printer", Quntity = 1, Price = 8000.0 });
        orders.Add(new Order { OrderNO = 6, ProductName = "Laptop", Quntity = 3, Price = 50000.0 });  // duplicate
        orders.Add(new Order { OrderNO = 7, ProductName = "Chair", Quntity = 4, Price = 2000.0 });
        orders.Add(new Order { OrderNO = 8, ProductName = "Desk", Quntity = 2, Price = 3000.0 });
        orders.Add(new Order { OrderNO = 9, ProductName = "Headphones", Quntity = 3, Price = 1500.0 });
        orders.Add(new Order { OrderNO = 10, ProductName = "USB Cable", Quntity = 10, Price = 200.0 });
        orders.Add(new Order { OrderNO = 11, ProductName = "Mouse", Quntity = 4, Price = 500.0 });     // duplicate
        orders.Add(new Order { OrderNO = 12, ProductName = "Webcam", Quntity = 2, Price = 2500.0 });
        orders.Add(new Order { OrderNO = 13, ProductName = "Microphone", Quntity = 1, Price = 3000.0 });
        orders.Add(new Order { OrderNO = 14, ProductName = "Laptop Bag", Quntity = 2, Price = 1500.0 });
        orders.Add(new Order { OrderNO = 15, ProductName = "Mouse Pad", Quntity = 5, Price = 300.0 });
    }

    public void aggregate()
    {
        Double sum = orders.Aggregate(0.0, (Total, Price) => Total + Price.Price * Price.Quntity);//first total value is 0.0 than update 
        Console.WriteLine("Total :" + sum);
        Console.WriteLine();

        var group = orders.GroupBy(d => d.ProductName);
        foreach (var item in group)
        {
            Console.WriteLine("Product Name : " + item.Key);
            double total = item.Aggregate(0.0, (total, pro) => total + (pro.Quntity * pro.Price));
            //double total = item.Sum(a => a.Quntity * a.Price);
            foreach (var item1 in item)
            {
                Console.WriteLine("Quntity :" + item1.Quntity + " Price :" + item1.Price);
            }
            Console.WriteLine(total);
            Console.WriteLine();
        }
    }
}