using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;      
using static ConsoleApp2.program;

namespace ConsoleApp2
{
   public class ssortingelementsinarray
    {
        public static void arraysort()
        {

            int input = 12345;
            int sum = 0;
            while (input > 0)
            {
                sum+= input % 10;
                input /= 10;
            }
            Console.WriteLine(sum);
        }
    }

    
    
    public class program
    {

       
        public static void Main(string[] args)
        {
            
            ssortingelementsinarray.arraysort();

        }
        
            
    }
}
    
  
    
       


