using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PerfectNumber
    {
        public static void FindNumber()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Find the perfect number within a give number of ");

            Console.WriteLine("Input the starting range or number");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range of number");
            mx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Perfect number withing the given range :");

            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;

                }
                if (sum == n)
                    Console.Write("{0}", n);

            }
            


        }
    }
}
