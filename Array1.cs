using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharrpday3
{
    class Array1
    {
        public static void arr()
        {
            // int[] number = new int[] { 1, 2, 3, 4, 5 };
            var number = new[] { 3, 2, 4, 6, 8, 6 };
            Console.WriteLine("Lenght of the array "+number.Length);

            var index = Array.IndexOf(number, 8);
            Console.WriteLine("index of the array "+index);

            //clear
            Console.WriteLine("clear the arry with  index ");
            Array.Clear(number,0, 2);
            foreach(var i in number)
            {
                Console.WriteLine(i);   
            }
            Console.WriteLine("copy for array");
            var anotherArray = new int[3];
            Array.Copy(number, anotherArray,3);
            foreach(var i in anotherArray)
            {
                Console.WriteLine(anotherArray);   
            }
            Console.WriteLine("sorting");
            Array.Sort(anotherArray);
            foreach( var i in number)
            {
                Console.WriteLine(i);
            }
            //reversing the array
            Array.Reverse(number);
            foreach ( var i in anotherArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
