using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs_Concepts
{
    //you can use multiple interface
    //forcefully padd all interface method in all inherited class
     interface IPayments
    {

         void ProcessPayment();
        //void account();//this is another method but not pass in other class so give error 
                        

    }

    class CreditCardPayment:IPayments
    {
        public void ProcessPayment()
        {
            Console.WriteLine("card No");
            Console.WriteLine("card Expiery");
        }
    }
    class UPIPayment : IPayments
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Upi No");
            Console.WriteLine("QR Code");
        }
    }
    class CashPayment : IPayments
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Acc. no");
            Console.WriteLine("Acc type");
        }
    }
}

