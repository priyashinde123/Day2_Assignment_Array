using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Array
{
    internal class Q4
    {
        public static void Execute()
        {
            int[] a = new int[5] {10,20,30,40,50};
           
            
            int [] b = new int[5];
            Console.WriteLine("The elements stored in the first array are :");
            for (int i = 0; i < a.Length; i++)
            {
               
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The elements copied into the second array are:");
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
                Console.Write(b[i] + " ");
            }
            


        }
    }
}
