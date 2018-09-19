using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.SOLID.DependecnyInversionPrinciple
{
    public class DependecnyInversionPrinciple
    {
        public static void Do()
        {
            var fl = new Customer(new FileLogger());
            fl.DoSomething();

            var dl = new Customer(new DatabaseLogger());
            dl.DoSomething();
        }
    }

    public interface ILogger
    {
        void Log(string msg);
    }

    public class FileLogger : ILogger
    {
        public void Log(string msg)
        {
            //Write to file
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string msg)
        {
            //Write to DB
        }
    }

    public class Customer
    {
        ILogger _logger;
        public Customer(ILogger logger)
        {
            _logger = logger;
        }

        public void DoSomething()
        {
            _logger?.Log("message to be logged...");
        }
    }
}
