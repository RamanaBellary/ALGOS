using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.SOLID.InterfaceSegregation
{
    public class InterfaceSegregation
    {
        public static void Do()
        {
            ICustomer customer = new SOLID.InterfaceSegregation.Customer();
            customer.AddToDatabase();

            ICustomerWithReadAccess newCustomer = new CustomerWithReadAccess();
            newCustomer.ReadFromDatabase();
        }
    }

    public interface ICustomer
    {
        void AddToDatabase();
    }

    public interface ICustomerWithReadAccess:ICustomer
    {
        string ReadFromDatabase();
    }

    public class Customer : ICustomer
    {
        public void AddToDatabase()
        {
            //Add to DB
        }
    }

    public class CustomerWithReadAccess : ICustomerWithReadAccess
    {
        public void AddToDatabase()
        {
            //Add to DB
        }

        public string ReadFromDatabase()
        {
            return "Read from DB";
        }
    }
}
