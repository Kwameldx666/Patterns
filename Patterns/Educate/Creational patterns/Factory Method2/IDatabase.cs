using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational_patterns.Factory_Method2
{
    public interface IDatabase
    {
        public void PushData();
        public void PopData();

    }

    public class MongoDb : IDatabase
    {
        public void PushData()
        {
            Console.WriteLine("sss");
        }
        public void PopData()
        {
            Console.WriteLine("PopMongo");
        }
    }

    public class SqlServer : IDatabase
    {
        public void PushData()
        {
            Console.WriteLine("sqlpush");
        }
        public void PopData()
        {
            Console.WriteLine("sqlpop");
        }
    }


    public abstract class FactoryDatabase
    {

        public string key = "lol";

        public abstract IDatabase CreateDB();

    }

    public class MongoFac:FactoryDatabase
    {
        public override IDatabase CreateDB()
        {

            return  new MongoDb();
        }
    }


    public class SqlServerFac:FactoryDatabase
    {
        public override IDatabase CreateDB()
        {

            return new SqlServer();
        }
    }
}
