using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] + A[j] == 25)
                    {
                        Console.WriteLine("The Sum of i : \t " + A[i] + "\t and j : \t " + A[j] + "\t is equal to 25");
                    }
                }
            }
            Console.WriteLine("******************Even And Odd**************************");
            int even = 0, odd = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("There are {0} Odd and {1} Even", odd, even);
            int sum = 0;
            //Average
            Console.WriteLine("------------Average---------");
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }
            Console.WriteLine("Average of all number is =\t" + sum / A.Length);
        }
    }
}
