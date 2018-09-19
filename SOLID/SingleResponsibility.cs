using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.SOLID
{
    //By having a FileLogger class which will take care of logging , we are using Single Resposibilty principle...
    public class FileLogger
    {
        public static void LogError(string message)
        {
            //Do the logging here..
        }
    }

    public class AuthenticateUser
    {
        public bool IsValidUser(string token)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(token))
                    return false;

                //LOGIC TO VALIDTE THE USER..

                return true;
            }
            catch(Exception exc)
            {
                FileLogger.LogError("Error : " + exc.Message);
            }
            return false;       
        }
    }
}
