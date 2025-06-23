using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational_patterns.AbstractFactory
{
    public abstract class Provider
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract IDatabase CreateSqlProvider();
        public abstract IDatabase CreateMongoDbProvider();


        public IDatabase CreateProvider(IDatabase provider)
        {
            return provider;
        }
    }



    public class ProviderOLEDb:Provider
    {
        public override IDatabase CreateSqlProvider()
        {
            return new SqlOLEDB();
        }

        public override IDatabase CreateMongoDbProvider()
        {
            return new MongoDBOLEDb();
        }
    
    }


    public class ProviderOLEDb2 : Provider
    {
        public override IDatabase CreateSqlProvider()
        {
            return new SqlOLEDB2();
        }

        public override IDatabase CreateMongoDbProvider()
        {
            return new MongoDBOLEDb2();
        }
    }

    public interface IDatabase
    {
        public void GetSqlData();
        public void SetSqlData(string sql);
    }

    public class SqlOLEDB : IDatabase
    {
        public void GetSqlData()
        {
            Console.WriteLine("GETSQL");
        }
        public void SetSqlData(string sql)
        {
            Console.WriteLine($"{sql}");
        }
    }

    public class MongoDBOLEDb : IDatabase
    {
        public void GetSqlData()
        {
            Console.WriteLine("GETSQL1");
        }
        public void SetSqlData(string sql)
        {
            Console.WriteLine($"{sql}sql");
        }
    }

    public class SqlOLEDB2 : IDatabase
    {
        public void GetSqlData()
        {
            Console.WriteLine("GETSQL");
        }
        public void SetSqlData(string sql)
        {
            Console.WriteLine($"{sql}");
        }
    }

    public class MongoDBOLEDb2 : IDatabase
    {
        public void GetSqlData()
        {
            Console.WriteLine("GETSQL1");
        }
        public void SetSqlData(string sql)
        {
            Console.WriteLine($"{sql}sql");
        }
    }
}
