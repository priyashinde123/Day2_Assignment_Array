using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Array
{
    internal class Q2
    {
        public static void Execute()
        {
            int[] a = new int[5];
            Console.WriteLine("enter the elemeints in array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            //Console.WriteLine("the elemnets of the arrays are:  ");
            for (int i = a.Length-1; 0<=i; i--)
            {
                Console.Write(a[i] + " ");
            }


        }
    }
}
