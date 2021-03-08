using Builder.Builder;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            var person = pb.AddName("Fulano")
                .AddWork("Professional Football Player")
                .Build();

            Console.WriteLine("Name: " + person.Name + "\n");
            Console.WriteLine("Work: " + person.Work + "\n");
            Console.ReadKey();
        }
    }
}