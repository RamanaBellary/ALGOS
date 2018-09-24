using ALGOS.DataStructures;
using ALGOS.SOLID.DependecnyInversionPrinciple;
using ALGOS.Tests;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ALGOS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //GenericsEx.Do();
                //CollectionsEx.Do();
                //OperatorsEx.Do();
                //DelegatesEx.Do();
                //EquitableEx.Do();
                //IComparerEx.Do();
                //ReflectionEx.Do();
                //SerializationAndDeSerialization.Do();
                //StackUsingLinkedList.Do();
                //QueueUsingLinkedList.Do();
                //MyLinkedList.Do();

                #region Sorting
                //SimpleAndInsertionSort.Do();
                #endregion

                #region Tests
                //IsPrimeNumber.Do();
                //IsWordAPalindrome.Do();
                //Fibinoics.Do();
                //CipherText.Do(); 
                //ManipulativeEmployee.Do();
                //taum_and_bday.Do();
                //TODO: HowManyLetters.Do();
                //EmployeeSacking.Do();
                //PrintPatternsOnScreen.Do();
                #endregion

                #region SOLID
                //DependecnyInversionPrinciple.Do();
                #endregion
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception occured :" + Environment.NewLine + exc.Message);
            }
            finally
            {
                GC.Collect();
                Console.WriteLine("Press any key to exit..");
                Console.ReadLine();
            }
        }
    }
}