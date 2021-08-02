using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {


            {
                String userInput = null;

                //Display title of program.
                Console.WriteLine("Basic Rock, Paper, Scissors Program in C#\r");
                Console.WriteLine("--------------------------------\n");


                Console.WriteLine("Let's see if you have what it takes!\n");


                while (userInput != "r" && userInput != "p" && userInput != "s")
                {
                    //Ask the user for their input.
                    Console.WriteLine("What do you choose for your option?");
                    Console.WriteLine("\tr - Rock");
                    Console.WriteLine("\tp - Paper");
                    Console.WriteLine("\ts - Scissors\n");

                    userInput = Console.ReadLine();

                }



                printUserInput(userInput);

                Console.WriteLine("Let's see what your opponent picks...");
                String robotInput = getRobotInput();

                determineWinner(userInput, robotInput);


                // Wait for the user to respond before closing.
                Console.Write("Press any key to close the Game.\n");
                Console.ReadKey();
            }
        }





        static void printUserInput(String userInput)
        {
            switch (userInput)
            {
                case "r":
                    Console.WriteLine("You chose... Rock!\n");
                    break;
                case "p":
                    Console.WriteLine("You chose... Paper!\n");
                    break;
                case "s":
                    Console.WriteLine("You chose... Scissors!\n");
                    break;
                default:
                    Console.WriteLine("Not a valid input!\n");
                    Console.WriteLine("Try again!\n");
                    break;
            }
        }

        static String getRobotInput()
        {
            String robotOption = null;
            Random rnd = new Random();
            int option = rnd.Next(1, 4);

            switch (option)
            {
                case 1:
                    Console.WriteLine("Your oppponent chose... Rock!");
                    robotOption = "r";
                    return robotOption;
                    break;

                case 2:
                    Console.WriteLine("Your oppponent chose... Paper!");
                    robotOption = "p";
                    return robotOption;
                    break;

                case 3:
                    Console.WriteLine("Your oppponent chose... Scissors!");
                    robotOption = "s";
                    return robotOption;
                    break;
                default:
                    return robotOption;
                    break;
            }

        }

        public enum Result { PlayerWin, RobotWin, Tie }

        static void determineWinner(String userInput, String robotOption)
        {
            Result outcome;

            if (userInput == robotOption)
            {
                Console.WriteLine("You tied!\n");
                outcome = Result.Tie;

            }

            else if (userInput == "r" && robotOption == "p")
            {
                Console.WriteLine("You lose!\n");

                outcome = Result.RobotWin;
            }

            else if (userInput == "r" && robotOption == "s")
            {
                Console.WriteLine("You win!\n");

                outcome = Result.PlayerWin;

            }

            else if (userInput == "p" && robotOption == "s")
            {
                Console.WriteLine("You lose!\n");

                outcome = Result.RobotWin;

            }

            else if (userInput == "p" && robotOption == "r")
            {
                Console.WriteLine("You win!\n");

                outcome = Result.PlayerWin;


            }

        }
    }
}

