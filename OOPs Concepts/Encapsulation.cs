using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOPs_Concepts
{
    internal class Bank
    {
        private int AccNo
        {
            get; set;
        }
        private double Balance { get; set; }


        public void Account(int accno, int initialbalance = 0)
        {
            AccNo = accno;
            Balance = initialbalance;
            Console.WriteLine("Your initialBalance is : " + initialbalance);
        }

        public void WithdrawMoney(double amount)
        {
            double remainBal = Balance - amount;
            if (Balance <= 0)
            {
                Console.WriteLine("Not Sufficient Balance");
                Console.WriteLine("Thank You !!");
            }
            if (remainBal <= 0)
            {
                Console.WriteLine("Not Sufficient Balance");
                Console.WriteLine("You Withdraw " + Balance + " and Less");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Withdraw :" + amount + " -> Your Remaining Balance " + Balance);
            }

        }
        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Your Balance is " + Balance);
        }

    }

    class Student
    {
        private int Math;
        private int Scince;
        private int Hindi;
        private int English;
        private string studentName;
        private int rollNo;

        public void StudentInfo(string stdName, int stdRollno)
        {
            studentName = stdName;
            rollNo = stdRollno;
            
        }
        public void addMark(int math, int scince, int hindi, int english)
        {
            if (math < 0 || scince < 0 || hindi < 0 || english < 0)
            {
                Console.WriteLine("Marks in Nagative");
            }
            Math = math;
            Scince = scince;
            Hindi = hindi;
            English = english;

           
        }
        public void ClculateAverage()
        {
            double avg = (Math + Scince + Hindi + English )/ 4.0;
            Console.WriteLine("Avrage is :" + avg);
        }
        public void Display()
        {
            Console.WriteLine("Student Name : " + studentName);
            Console.WriteLine("Student Roll no : " +rollNo);
            Console.WriteLine("----------------------------------");
        }
    }
}
