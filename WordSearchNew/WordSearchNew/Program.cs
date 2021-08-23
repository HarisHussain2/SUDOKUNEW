using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearchNew
{
    class Program
    {
static void Main()
        {
            string tryAgain;
            string Name;
            int Score = 0;

            RulesDisplay RulesInstance = new RulesDisplay();
            RulesInstance.RulesDisplayMethod();

            Console.WriteLine("Enter your Name : ");
            Console.WriteLine();
            Name = Console.ReadLine();

            while (true)
            {
                WordFindSolve WordFindSolveInstance = new WordFindSolve();
                Score = Score + WordFindSolveInstance.WordFindSolveMethod();

            z:

                Console.WriteLine();
                Console.WriteLine("Would you like to play another again? {Yes or No} | ");
                tryAgain = Console.ReadLine().ToUpper();
                if (tryAgain == "YES")
                {

                }
                else if (tryAgain == "NO")
                {
                    Console.WriteLine();
                    Console.WriteLine("Thanks for playing WordFind.");
                    Console.WriteLine();

                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Valid Option :");
                    Console.WriteLine();
                    goto z;
                }
            }

            Console.WriteLine("{0} score is : {1}", Name,Score);
            Console.WriteLine();
        }

    }
}


