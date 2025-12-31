using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceTopics
{
    delegate void RingedDelegate();
    delegate void StandupDelegate();
    internal class Bell
    {
        public event RingedDelegate ringed;//create event
        public event StandupDelegate standup;//second event
        public void Ring()
        {
            Console.WriteLine("Bell Ringging");
            ringed?.Invoke();
        }
        public void MakeStudentsStandUp()
        {
            Console.WriteLine("Student stood up");
            standup?.Invoke();

        }
        public void ReadyForSchool()
        {
            Console.WriteLine("Im ready For School !");
        }

    }

    class Student
    {
        public void Standup()
        {
            Console.WriteLine("Student stood up");
        }
    }
}
