using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharrpday3
{
    public class Guesiingnumbe
    {
        public void guessnumber()

        {
            Console.WriteLine("Guessing number game ");
            Console.WriteLine("Enter the number between 1 to 10");
            var random = new Random();
            int guessNum = random.Next(1, 10);
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Gues the number and chances " + i);
                var input = int.Parse(Console.ReadLine());
                if (input == guessNum)
                {
                    Console.WriteLine("You won the game");
                    break;
                } else if (input > guessNum) {
                    Console.WriteLine("Too big number please enter small number");
                }
                else if (input < guessNum) 
                    {
                        Console.WriteLine("Too small please enter the big number");
                }
                else
                {
                    Console.WriteLine("You lost the game");

                }

            }
            }

        }
    }
