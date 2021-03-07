using AbstractFactory.Database;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DbAbstractFactory sql = new SqlFactory();

            var conSql = sql.CreateConnection();
            conSql.Open();

            var cmdSql = sql.CreateCommand();
            cmdSql.Execute();




            DbAbstractFactory oracle = new OracleFactory();

            var conOracle = oracle.CreateConnection();
            conOracle.Open();

            var cmdOracle = oracle.CreateCommand();
            cmdOracle.Execute();

            Console.ReadLine();
        }
    }
}
