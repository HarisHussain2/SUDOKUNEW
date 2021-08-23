using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WordSearchNew
{
    class WordFindSolve
    {
        public int WordFindSolveMethod()
        {
            string[] countries = { "austria\0", "brazil\0", "canada\0", "cuba\0", "fiji\0", "iraq\0", "italy\0", "japan\0", "jordan\0", "nepal\0" };

            string[] countries2 = { "austria", "brazil", "canada", "cuba", "fiji", "iraq", "italy", "japan", "jordan", "nepal" };

            char[,] grid = new char[10, 10];

            Random r = new Random();

            int indexWord = r.Next(10); // For selecting random countries

            #region Assigning Random Characters To Grid
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

                    char c = letters[r.Next(0, 25)];

                    grid[i, j] = c;
                }
            } 
            #endregion

            string outputCountry = countries2[indexWord]; // For making hints

            #region Even Words Vertically Arranged
            if (countries[indexWord].Length % 2 == 0)
            {
                //Vertically
                int row = r.Next(0, 10);
                int col = r.Next(0, 3);
                for (int i = 0; countries[indexWord][i] != '\0'; i++, col++)
                {
                    grid[row, col] = countries[indexWord][i]; // countries variable will place word Vertically one by one
                }
            } 
            #endregion
            #region Odd Words Horizontally Arranged
            else
            {
                //horizontaly
                int row = r.Next(3);
                int col = r.Next(10);
                for (int i = 0; countries[indexWord][i] != '\0'; i++, row++)
                {
                    grid[row, col] = countries[indexWord][i]; // countries variable will place word horizontally one by one
                }
            } 
            #endregion

            #region Grid Display
            Console.WriteLine();
            Console.WriteLine("*****WordFind*****");
            Console.WriteLine();

            Console.WriteLine(grid[0, 0] + " " + grid[0, 1] + " " + grid[0, 2] + " " + grid[0, 3] + " " + grid[0, 4] + " " + grid[0, 5] + " " + grid[0, 6] + " " + grid[0, 7] + " " + grid[0, 8] + " " + grid[0, 9]);
            Console.WriteLine(grid[1, 0] + " " + grid[1, 1] + " " + grid[1, 2] + " " + grid[1, 3] + " " + grid[1, 4] + " " + grid[1, 5] + " " + grid[1, 6] + " " + grid[1, 7] + " " + grid[1, 8] + " " + grid[1, 9]);
            Console.WriteLine(grid[2, 0] + " " + grid[2, 1] + " " + grid[2, 2] + " " + grid[2, 3] + " " + grid[2, 4] + " " + grid[2, 5] + " " + grid[2, 6] + " " + grid[2, 7] + " " + grid[2, 8] + " " + grid[2, 9]);
            Console.WriteLine(grid[3, 0] + " " + grid[3, 1] + " " + grid[3, 2] + " " + grid[3, 3] + " " + grid[3, 4] + " " + grid[3, 5] + " " + grid[3, 6] + " " + grid[3, 7] + " " + grid[3, 8] + " " + grid[3, 9]);
            Console.WriteLine(grid[4, 0] + " " + grid[4, 1] + " " + grid[4, 2] + " " + grid[4, 3] + " " + grid[4, 4] + " " + grid[4, 5] + " " + grid[4, 6] + " " + grid[4, 7] + " " + grid[4, 8] + " " + grid[4, 9]);
            Console.WriteLine(grid[5, 0] + " " + grid[5, 1] + " " + grid[5, 2] + " " + grid[5, 3] + " " + grid[5, 4] + " " + grid[5, 5] + " " + grid[5, 6] + " " + grid[5, 7] + " " + grid[5, 8] + " " + grid[5, 9]);
            Console.WriteLine(grid[6, 0] + " " + grid[6, 1] + " " + grid[6, 2] + " " + grid[6, 3] + " " + grid[6, 4] + " " + grid[6, 5] + " " + grid[6, 6] + " " + grid[6, 7] + " " + grid[6, 8] + " " + grid[6, 9]);
            Console.WriteLine(grid[7, 0] + " " + grid[7, 1] + " " + grid[7, 2] + " " + grid[7, 3] + " " + grid[7, 4] + " " + grid[7, 5] + " " + grid[7, 6] + " " + grid[7, 7] + " " + grid[7, 8] + " " + grid[7, 9]);
            Console.WriteLine(grid[8, 0] + " " + grid[8, 1] + " " + grid[8, 2] + " " + grid[8, 3] + " " + grid[8, 4] + " " + grid[8, 5] + " " + grid[8, 6] + " " + grid[8, 7] + " " + grid[8, 8] + " " + grid[8, 9]);
            Console.WriteLine(grid[9, 0] + " " + grid[9, 1] + " " + grid[9, 2] + " " + grid[9, 3] + " " + grid[9, 4] + " " + grid[9, 5] + " " + grid[9, 6] + " " + grid[9, 7] + " " + grid[9, 8] + " " + grid[9, 9]);

            Console.WriteLine();
            Console.WriteLine("*****WordFind*****");
            Console.WriteLine(); 
            #endregion

            #region Countries List Display
            Console.WriteLine("The list of countries name is given as (Find the hidden one in the grid above): ");
            Console.WriteLine();

            Console.WriteLine("{0}", string.Join(", ", countries)); 
            #endregion

            string guess;
            string hint;
            string tryAgain;

            Console.WriteLine();
            Console.WriteLine("Press A for guessing name directly.");
            Console.WriteLine("Press B to firstly see hint and then guess the name.");
            Console.WriteLine();

        a:
            Console.WriteLine("Select option A or B:       ");
            Console.WriteLine();
            hint = Console.ReadLine().ToUpper();

            if (hint == "A")
            {

                Console.WriteLine();
                Console.WriteLine("Enter Your Guessed Name  :   OR {Enter r to return to select another option}");
                guess = Console.ReadLine();
                Console.WriteLine();
                if (guess == "r")
                {
                    goto a;
                }
                else
                {

                }
            }
            else if (hint == "B")
            {
                Console.WriteLine();
                Console.WriteLine("Hint: The guessed country name size is : {0}", outputCountry.Length);
                Console.WriteLine("Hint: The guessed country name first letter is : {0}", outputCountry[0]);
                Console.WriteLine();

                Console.WriteLine("Enter Your Guessed Name  :  OR {Enter r to return to select another option}");
                guess = Console.ReadLine();
                if (guess == "r")
                {
                    goto a;
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Enter Valid Option :");
                Console.WriteLine();
                goto a;
            }

            if (outputCountry == guess)
            {
                Console.WriteLine();
                Console.WriteLine("Congratulations! You have guessed the right word in the grid.");

                return 10;
            }
            else
            {
            x:
                Console.WriteLine();
                Console.WriteLine("Sorry you guessed the wrong country name | Would you like to try again? {Yes or No}");
                Console.WriteLine();
                tryAgain = Console.ReadLine().ToUpper();
                Console.WriteLine();
                if (tryAgain == "YES")
                {
                    goto a;
                }
                else if (tryAgain == "NO")
                {
                    return 0;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter Valid Option :");
                    Console.WriteLine();
                    goto x;
                }
            }

        }
    }
}
