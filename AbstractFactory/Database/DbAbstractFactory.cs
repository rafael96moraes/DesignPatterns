using AbstractFactory.Database.Command;
using AbstractFactory.Database.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Database
{
    abstract class DbAbstractFactory
    {
        public abstract DbConnection CreateConnection();

        public abstract DbCommand CreateCommand();
    }

    class SqlFactory : DbAbstractFactory
    {
        public override DbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public override DbCommand CreateCommand()
        {
            return new SqlCommand();
        }
    }

    class OracleFactory : DbAbstractFactory
    {
        public override DbConnection CreateConnection()
        {
            return new OracleConnection();
        }

        public override DbCommand CreateCommand()
        {
            return new OracleCommand();
        }
    }

}
