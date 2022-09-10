using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Array
{
    internal class Sortarr1
    {

        public static void Execute()
        {
            int[] a = new int[5] { 1,2, 4, 20, 71 };
            int[] b = new int[5] { 5, 6, 13, 52, 77};
            int[] c = new int[a.Length+b.Length];
            int ind = 0;
            bool flag=false;
            for(int i=0;i<a.Length; i++)
            {
                for(int j=0;j<b.Length; j++)
                {
                    if (b[j] < a[i])
                    {
                        int tmp = a[i];
                        a[i] = b[j];
                        b[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            { if (flag == false)
                { 
                    c[ind++] = a[i];
                if (i == a.Length - 1)
                {
                    
                    i = 0;
                    flag = true;

                }
             }
                if (flag)
                {
                    c[ind++] = b[i];
                    if (ind == a.Length + b.Length+1)
                        break;
                }

            }
            for(int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }

}
