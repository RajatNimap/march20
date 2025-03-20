using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharrpday3
{
    class Arraylogical
    {
        public static void message()
        {
            var newlist=new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    newlist.Add(input);
                    if (newlist.Count == 1)
                    {
                        Console.WriteLine(newlist[0]);
                        
                    }
                    else if (newlist.Count == 2) { 
                    Console.WriteLine(newlist[0]+"  "+newlist[1]);
                        
                    }
                    else
                    {
                        Console.WriteLine(newlist[0] + "  " + newlist[1]+" "+ newlist.Count+" peopel");
                        

                    }
                }
               
                
                
            }
        }
    }
}
