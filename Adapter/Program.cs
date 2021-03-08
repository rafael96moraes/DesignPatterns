using Adapter.Adapter;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultB3 = new B3RealEstateFundsService();

            var xp = new XPRealEstateFundsJSON(resultB3);

            Console.WriteLine(xp.ConvertToJson());

            Console.ReadKey();
        }
    }
}
