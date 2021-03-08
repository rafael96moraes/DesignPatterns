using FactoryMethod.VariableIncome;
using FactoryMethod.VariableIncome.Messages;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            new Email().SendEmailRealEstateFunds();


            new Email().SendEmailEquities();

            Console.ReadLine();
        }
    }

    class Email
    {
        internal void SendEmailRealEstateFunds()
        {
            Start(new RealEstateFundsTemplate());
        }

        internal void SendEmailEquities()
        {
            Start(new EquitiesTemplate());
        }

        void Start(EmailFactoryMethod factory)
        {
            factory.SendMessage();
        }
    }
}