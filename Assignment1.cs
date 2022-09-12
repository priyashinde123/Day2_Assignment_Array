using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Assignment1
    {
        public static void execute()
        {

            List<int> list = new List<int>();
            int sum = 0;
            while (true)
            {
                Console.WriteLine("enter the number");
                var result=Console.ReadLine();
                int value = 0;
                bool validConversionOrNot=int.TryParse(result, out value);  
                if(validConversionOrNot)
                {
                    list.Add(Convert.ToInt32(result));
                    sum += Convert.ToInt32(result);
                }
                else
                {
                   result=result.ToUpper(); 
                    if (result == "STOP")
                        break;
                    else
                    {
                        Console.WriteLine("not valid input");
                        break;
                    }
                }
                

              

            }
            Console.WriteLine($"sum of num is {sum}");
        }
            
    }
}
