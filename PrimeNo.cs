using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class PrimeNo
    {
        public static void DisplayPrimeNo()
        {
            int n, i, m = 0, flag = 0;
            Console.WriteLine("Enter the number to check prime");

            n=int.Parse(Console.ReadLine());

            m = n / 2;
            for(i=2;i<=m;i++)
            {

                if (n % i == 0)
                {
                    Console.WriteLine("Number is not Prime");
                    flag = 1;
                    break;
                }
            }
            if(flag == 0) 
            {
                Console.WriteLine("Number is Prime");
            }

        }
    }
}
