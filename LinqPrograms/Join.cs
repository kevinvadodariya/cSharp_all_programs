using LinqPrograms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LinqPrograms
{
    class Student
    {

        //type of joins : Left,right,inner,outer(Full)

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> students = new List<Student>();
        public void Add()
        {
            students.Add(new Student { Id = 1, Name = "Alice" });
            students.Add(new Student { Id = 2, Name = "Bob" });
            students.Add(new Student { Id = 3, Name = "Charlie" });
            students.Add(new Student { Id = 4, Name = "David" });
            students.Add(new Student { Id = 5, Name = "Goli" });
            students.Add(new Student { Id = 7, Name = "Charlie" });
            students.Add(new Student { Id = 8, Name = "David" });
            students.Add(new Student { Id = 9, Name = "Goli" });

        }
    }

    class Course
    {
        public int StudentId { get; set; }
        public string CourseName { get; set; }
        public List<Course> courses = new List<Course>();
        public void Add()
        {
            courses.Add(new Course { StudentId = 1, CourseName = "Math" });
            courses.Add(new Course { StudentId = 2, CourseName = "Scince" });
            courses.Add(new Course { StudentId = 3, CourseName = "History" });
            courses.Add(new Course { StudentId = 4, CourseName = "Biology" });
            courses.Add(new Course { StudentId = 5, CourseName = "English" });
            courses.Add(new Course { StudentId = 7, CourseName = "Com." });
            courses.Add(new Course { StudentId = 8, CourseName = "Math" });
            courses.Add(new Course { StudentId = 9, CourseName = "Scince" });
            courses.Add(new Course { StudentId = 10, CourseName = "History" });
            courses.Add(new Course { StudentId = 15, CourseName = "Biology" });
            courses.Add(new Course { StudentId =25, CourseName = "English" });
            courses.Add(new Course { StudentId = 17, CourseName = "Com." });
        }
    }

}
