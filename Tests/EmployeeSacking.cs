using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.Tests
{
    /*
     Employee Sacking
An employer is suspicious of his employees! He thinks that there is a great likelihood that they are going to quit. He decides to fire all those employees who are within D “distance” (where distance is defined below) of an employee A who had quit recently. Call this number D the threshold distance.

The distance function Bd

The distance function Bd (P, Q) between two vectors P, Q of the same dimension is the number of positions in which the corresponding components are different. Essentially it’s similar to the Hamming Distance!

Example:

Given two vectors P = (1,2,3) and Q = (4, 1, 3), Bd(P, Q) = 1 + 1 + 0 = 2 as the 1st and 2nd components of vector P are different from the 1st and 2nd components in vector Q.

Each employee in the company is described by a vector with C components. Here each component is an integer. Call this vector the characteristic vector.

Input format

The first line of input consists of the integer T. Then the first line of each test case consists of three integers E, C and D. Here E is the number of employees in the company, C is the number of components of the vector characterizing each employee, and D is the threshold distance as defined above. Then E + 1 lines follow with the input as follows:

E00 E01 … E0C

E10 E11 … E1C

…

EE0 EE1 … EEC

The characteristics vector of the employee A who quit is given by (E00, E01, … , E0C)

The characteristics vector of employee Ai is given by (Ei0, Ei1, …, EiC) where i ranges from 1 to E.

Overall each test case is as follows:

E C D

E00 E01 … E0C

E10 E11 … E1C

…

EE0 EE1 … EEC

Output format

The output is an integer Y that is the number of employees the employer is going to fire. Essentially, the number of employees whose characteristics satisfy the equation:

Bd(A,Ai) <= D

Constraints

1<= T <= 10000

1 <= E <= 100000

1 <= C <= 10000

1 <= D <= ceil (C/50)

1 <= Eij <= 10000000000

Sample Input

1
5 3 1
1 2 3
4 1 2
5 1 6
1 5 9
3 2 7
7 1 3
Sample Output

3

//
Sample STDInput1
5
5 3 2
4 10 2
7 8 10
10 4 3
1 2 6
2 7 2
7 3 8
5 3 1
1 2 3
4 1 2
5 1 6
1 5 9
3 2 7
7 1 3
8 4 1
2 6 8 10
1 5 4 5
6 2 4 1
6 3 6 2
4 4 9 3
5 3 1 4
6 5 6 7
1 4 5 6
5 10 6 7
18 3 2
1 5 9
4 2 9
3 10 9
3 4 1
4 1 4
7 4 7
7 2 2
6 2 2
6 10 9
5 10 2
2 8 4
6 9 5
1 10 8
4 9 7
4 2 4
1 1 6
7 3 10
3 5 2
3 2 2
2 4 2
4 1 4 7
4 10 4 4
2 5 5 2

STDOutput1
1
0
0
6
1
     */
    public class EmployeeSacking
    {
        public static void Do()
        {
            long t = 0;
            if (long.TryParse(Console.ReadLine(), out t) && t >= 1 && t <= 10000)
            {
                for (long i = 0; i < t; i++)
                {
                    int count = 0;
                    string[] arr = Console.ReadLine()?.Split(new char[] { ' ' });
                    double e = Convert.ToInt64(arr[0]);
                    double c = Convert.ToInt64(arr[1]);
                    double d = Convert.ToInt64(arr[2]);

                    if (e >= 1 && e <= 100000 && c >= 1 && c <= 10000 && d >= 1 && d <= Math.Ceiling(c / 50))//
                    {
                        long[] empArr = null;
                        for (int j = 0; j < e + 1; j++)
                        {
                            if (j == 0)
                            {
                                var val = Console.ReadLine();
                                empArr = val.Split(new char[] { ' ' }).Select((v) => Convert.ToInt64(v)).ToArray();
                            }
                            else
                            {
                                var val = Console.ReadLine();
                                int cnt = 0;
                                var arrToLookFor = val.Split(new char[] { ' ' }).Select((v) => Convert.ToInt64(v)).ToArray();
                                for (int k = 0; k < empArr.Length; k++)
                                {
                                    if (empArr[k] == arrToLookFor[k])
                                        cnt++;
                                }
                                if (cnt > 0 && cnt <= d)
                                    count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    else
                        Console.WriteLine("0");
                }
            }
            else
                Console.WriteLine("0");
        }
    }
}
