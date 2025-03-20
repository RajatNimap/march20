using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharrpday3
{
    class string1
    {
        public static void workingonStr()
        {
            var name = "     Rajat Pandit ";
            var name1 = "Niraj Pandit";
            Console.WriteLine(name.Trim().ToUpper());
            Console.WriteLine(name1.ToLower());
            var index=name1.IndexOf(' ');
            var firstname = name1.Substring(0, index);
            var lastname = name1.Substring(index + 1);
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            var str = name1.Split(' ');
            Console.WriteLine(str[0]+" " + str[1]);
            Console.WriteLine(name1.Replace("Ni", "Rajat"));
            var name2 = " ";
            if (String.IsNullOrEmpty(name2.Trim()))
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
                
            }
            var str1 = "25";
            var age=Convert.ToInt32(str1);
            Console.WriteLine(age);
            float price = 29.95f;
            Console.WriteLine(price.ToString("C1"));

        }
        public static void summarize()
        {
            var sentence = "My name is Rajat Pandit I am living in bhiwandi there is great season here";
            const int maxlen= 10;

            if(sentence.Length < maxlen)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var str=sentence.Split(' ');
                var totalcharacter = 0;

                var number = new List<string>();
                foreach(var word in str)
                {

                    number.Add(word);
                    totalcharacter+=word.Length+1;
                    if(totalcharacter > maxlen)
                    {
                        break;
                    }
                }
               var summary= String.Join(" ",number)+"...";
                Console.WriteLine(summary);
            }
        }
    }
}
