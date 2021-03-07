using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Database
{
    abstract class DbCommand
    {
        public abstract void Execute();
    }
}
