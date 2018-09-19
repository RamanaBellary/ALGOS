using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.SOLID
{
    public interface IEmployee
    {
        string GetProjectDetails(int empID);
    }

    public interface IPermanentEmployee : IEmployee
    {
        double GetSalaryDetails(int empID);
    }

    public class PermanentEmployee : IPermanentEmployee
    {
        public string GetProjectDetails(int empID)
        {
            return "Permanent Employee Project Details";
        }

        public double GetSalaryDetails(int empID)
        {
            return 1000;
        }
    }

    public class ContractEmployee : IEmployee
    {
        public string GetProjectDetails(int empID)
        {
            return "Contract Employee Project Details";
        }
    }

    public class SubstituionPrinciple
    {
        public static void Do()
        {
            List<IEmployee> lstEmployeeDetails = new List<SOLID.IEmployee>();
            lstEmployeeDetails.Add(new PermanentEmployee());
            lstEmployeeDetails.Add(new ContractEmployee());
            lstEmployeeDetails[0].GetProjectDetails(1);
        }
    } 
}
