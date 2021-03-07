using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Database.Command
{
    class SqlCommand : DbCommand
    {
        public override void Execute()
        {
            Console.WriteLine("Executing the SQL command...");
        }
    }
}
