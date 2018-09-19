using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.Tests
{
    public class PrintPatternsOnScreen
    {
        public static void Do()
        {
            Patter1();
        }

        /* 
         $
       $   $             
     $   $   $         
    $  $   $   $               
        */
        private static void Patter1()
        {
            Console.WriteLine("Enter the nuber of lines to print");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for(int s = n-i; s > 0; s--)
                {
                    Console.Write(" ");
                }

                int starsCount = 0;
                bool alternateFlag = true;
                while(starsCount < i )
                {
                    if (alternateFlag)
                    {
                        Console.Write("$");
                        starsCount++;
                    }
                    else
                        Console.Write(" ");
                    alternateFlag = !alternateFlag;
                }
            }
            Console.WriteLine(" ");
        }
    }
}
