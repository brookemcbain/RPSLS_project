using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        //member variables
        Player playerOne;
        Player playerTwo;
        string response; 

        //constructor
        public Game()
        {
            playerOne = new Human();
        }

        //member methods

        public void ChooseGameMode()
        {
            //This needs validation
            Console.WriteLine("Do you want one player or two? Type '1' or '2':");
            response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    playerTwo = new Computer();
                    break;
                case "2":
                    playerTwo = new Human();
                    break;
                default:
                    break;  
                
            }
            if(response != 1 || response != 2)
            {
                Console.WriteLine("Your answer is invalid, please type '1' or '2'");
                ChooseGameMode(); 
            }
            
        }

        public void RunGame()
        {
            //Intro Section
            //Greeting/Welcome
            //Rules
            Console.WriteLine("Welcome to ROCK, PAPER, SCISSORS, LIZARDS, SPOCK! ");
            Console.WriteLine("Here are the rules");
            Console.WriteLine("Rule #1: Player 1 choose whether they'd like to play against another Player or a computer");
            Console.WriteLine("Rule #2: Choose either Rock, Paper, Scissors, Lizard, or Spock");
            Console.WriteLine("Rock crushes Scissors and Lizard, Scissors cuts Paper and decapitates Lizard ");
            Console.WriteLine("Paper covers Rock and disproves Spock, Lizard poisons Spock and eats Paper");
            Console.WriteLine("Spock smashes Scissors and vaporizes Rock");
            Console.WriteLine("LET THE BATTLE BEGIN");

            //Choose game type - PvP or PvComputer
            ChooseGameMode();

            //Optional setup - Choose Rounds? Enter player names?

            //Gameplay Rounds Section
            //Display current state of game points
            //Display gesture options
            //Player One Chooses a gesture
            //Display gesture options
            //Player Two Chooses a gesture
            //Compare the gestures, decide who wins, winner gets a point
            //Display outcome of round
            //Utilize a check on points to see if we need another round


            //EndGame/Victory Section
            //Display winner of game
            //Optionally prompt for a new game


        }

        //Do we want a Round/Battle class?
        //Do we want a Gesture class?
        //Choosing a Gesture - override a method for player or computer?
        //Players need a point variable
        //Players need a list of gestures
        //Players need a "chosen gesture" variable
    }

}
