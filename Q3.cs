using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Array
{
    internal class Q3
    {
        public static void Execute()
        {
            int[] a = new int[5];
            Console.WriteLine("enter the elemeints in array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine($"Sum of all elements stored in the array is : {sum} ");

        }
    }
}
