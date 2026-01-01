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
                Salary = 27000,
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
                Name = "Jack",
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
            var data = listnum.GroupBy(a => a.Skills[0]);
            foreach (var item in data)
            {
                Console.WriteLine("Skills: "+item.Key);
                foreach (var item1 in item)
                {
                    Console.WriteLine("Id :-"+item1.Id+" "+item1.Name);
                }
                Console.WriteLine();
                Console.WriteLine("--------");
            }
        }
    }
}
