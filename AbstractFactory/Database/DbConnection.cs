using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Database
{
    abstract class DbConnection
    {
        public abstract void Open();
    }
}
