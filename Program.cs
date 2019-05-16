using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cubed Numbers";
            bool repeat = true;
            do
            {
                AskQuestion();
            } while (repeat == true);
        }

        static void AskQuestion()
        {
            bool end = false;
            Random rand = new Random();

            int x = rand.Next(1, 100);
            int cubed = x * x * x;

            Console.Write("What is the cube root of " + cubed + ": ");
            int userAnswer = GetUserInput();

            do
            {
                if (userAnswer == x)
                {
                    Console.WriteLine("Correct!");
                    end = true;
                }
                else
                {
                    Console.Write("Incorrect, try again: ");
                    userAnswer = GetUserInput();
                }
            } while (end == false);
        }

        static int GetUserInput()
        {
            int answer = 0;
            string userInput = Console.ReadLine();
            try
            {
                int.TryParse(userInput, out answer);
            }
            catch (FormatException)
            {

            }

            return answer;
        }

    }
}
