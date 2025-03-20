using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Csharrpday3
{
    class sereis
    { 
        public static void sseries()
        {
            Console.WriteLine("Please enter series of number and it should separated by comma");

            var input= Console.ReadLine();
            var result = input.Split(",");
            int greater = -1;
            for (int i = 0; i < result.Length; i++)
            {
                if(int.Parse(result[i]) > greater)
                {
                    greater=int.Parse(result[i]);
                }

            }
            Console.WriteLine("the greater number "+greater);
        }
        
            
    }
}
