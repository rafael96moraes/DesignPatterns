﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Database.Config
{
    class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Connection to SQL");
        }
    }
}
