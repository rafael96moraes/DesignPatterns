using Builder.Builder;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            var person = pb.Called("Fulano")
                .AddWork("Professional Football Player")
                .Build();
        }
    }
}