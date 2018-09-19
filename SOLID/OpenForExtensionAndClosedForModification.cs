using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.SOLID
{
    #region Example1
    public class Customer
    {
        public virtual double GetDiscount(double totalPrice)
        {
            return totalPrice;
        }
    }

    public class SilverCustomer : Customer
    {
        public override double GetDiscount(double totalPrice)
        {
            return base.GetDiscount(totalPrice) - 25;
        }
    }

    public class GoldCustomer : Customer
    {
        public override double GetDiscount(double totalPrice)
        {
            return base.GetDiscount(totalPrice) - 50;
        }
    }
    #endregion
    #region Example2
    public interface IErrorNotifier
    {
        object Notify();
    }

    public class EmailNotification : IErrorNotifier
    {
        public object Notify()
        {
            throw new NotImplementedException();
        }
    }

    public class Logger : IErrorNotifier
    {
        public object Notify()
        {
            throw new NotImplementedException();
        }
    }

    public class TestSOLID
    {
        public static void Do()
        {
            IErrorNotifier eNotifier = new EmailNotification();
            eNotifier.Notify();

            IErrorNotifier logNotifier = new Logger();
            logNotifier.Notify();
        }
    } 
    #endregion
}
