using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program

    {
        
        static void Main(string[] args)

        {
           
            bool checking = true;
            string userOpponent;
            string playerchoice = " ";

            Console.WriteLine("Whats up Bruh! It's time to play Rock Paper Sciccors ");
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine();


            while (checking)
            {
                Console.WriteLine("Who would you like play against today?");
                Console.WriteLine("Your options are: ShyKeca, Shekera or Jermale?");
                userOpponent = Console.ReadLine();
                Console.WriteLine();

                PlayerThree PlayerThreeChoice = new PlayerThree();
                //To print Player 3 name
                PlayerThreeChoice.Name();
                //To generate Jermale's choice of RPS
                PlayerThreeChoice.GenerateRoshambo();



                if (userOpponent == "shykeca  " || userOpponent == "Shykeca")
                {
                    //Method for user chosing Rock
                    PlayerOne PlayerOneChoice = new PlayerOne();

                    playerchoice = PlayerOneChoice.Player1Option().ToLower();
                }

                else if (userOpponent == "shekera" || userOpponent == "Shekera")
                {
                    //Method for user choosing Paper
                    PlayerTwo PlayerTwoChoice = new PlayerTwo();

                    playerchoice = PlayerTwoChoice.GenerateRoshambo().ToLower();
                }
                else if (userOpponent == "Jermale" || userOpponent == "jermale")
                {
                    PlayerThree Player3Choice = new PlayerThree();

                    PlayerThreeChoice.Name();
                    PlayerThreeChoice.GenerateRoshambo().ToLower();
                }

                else
                {
                    checking = false;
                    Console.WriteLine("Error, you did not choose the right person name");
                    Continue();
                    //The bool from the while loop above will be false in this < else >

                }

                {
                    Console.WriteLine("Ok Lets play! Your turn first!");
                    Console.WriteLine("Please choose between: Rock, Paper or Sciccors");
                    string userDecision = Console.ReadLine().ToLower();
                    Console.WriteLine();



                    Console.WriteLine(userName + " chooses " + userDecision);
                    Console.WriteLine(userOpponent + " chooses a " + playerchoice);
                    //Insert Instatiation for checking the user decision

                    //insert Method for Checking User Decision 



                    if (userDecision == "rock" && playerchoice == "rock")
                    {
                        Console.WriteLine("It's a Tie!");
                    }

                    else if (userDecision == "rock" && playerchoice == "paper")
                    {
                        Console.WriteLine(userOpponent + " Wins!");
                        Console.ReadLine();
                    }


                    else if (userDecision == "rock" && playerchoice == "sciccors")
                    {
                        Console.WriteLine("You win!");
                    }

                    else if (userDecision == "paper" && playerchoice == "sciccors")
                    {
                        Console.WriteLine(userOpponent + " Wins!");
                    }
                    else if (userDecision == "paper" && playerchoice == "rock")
                    {
                        Console.WriteLine(userOpponent + " Wins!");
                    }
                    else if (userDecision == "paper" && playerchoice == "paper")
                    {
                        Console.WriteLine(" Its a tie!");
                    }
                    else if (userDecision == "sciccors" && playerchoice == "rock")
                    {
                        Console.WriteLine(userOpponent + " Wins!");
                    }
                    else if (userDecision == "sciccors" && playerchoice == "sciccors")
                    {
                        Console.WriteLine(" Its a tie!");
                    }
                    else if (userDecision == "sciccors" && playerchoice == "paper")
                    {
                        Console.WriteLine(userOpponent + " Wins!");
                    }
                    else if (userDecision != "sciccors" || userDecision != "paper" || userDecision != "rock")

                    {
                        Console.WriteLine("Error, you did not choose between Rock, Paper or Sciccors");
                        Continue();
                        //The bool from the while loop above will be false in this < else >

                         checking = false;
                    }


                }

            }
        }


        public static Boolean Continue()

        {
            Boolean run;

            Console.WriteLine("Continue? Y/N");

            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))

            {
                run = true;
            }

            else if ((answer == "N") || (answer == "n"))

            {
                run = false;

                Console.WriteLine("Good Bye!");
            }

            else

            {

               Console.WriteLine("I'm sorry I don't understand. Let's try again");

                run = Continue();

            }
            return run;

        }


    }


}

        
