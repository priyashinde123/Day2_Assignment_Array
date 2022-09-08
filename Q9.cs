using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Array
{
    internal class Q9
    {
        public static void Execute()
        {
            int[] a = new int[5];
            int minval = int.MaxValue;
            int maxval=int.MinValue;
            Console.WriteLine("enter the elemeints in array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]<minval)
                    minval = a[i];
                if(a[i]>maxval)
                    maxval = a[i];
            }

            Console.WriteLine($"Minimum value :{minval}");
            Console.WriteLine($"Maximum value : {maxval}");
        }
    }
}
