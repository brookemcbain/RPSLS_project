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
            if (!response.Equals("1") && !response.Equals("2"))
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
            Console.WriteLine("Here are the rules:");
            Console.WriteLine("Rule #1: Player 1 chooses whether they'd like to play against another Player or the computer");
            Console.WriteLine("Rule #2: Choose either Rock, Paper, Scissors, Lizard, or Spock");
            Console.WriteLine("Rock crushes Scissors and Lizard");
            Console.WriteLine("Scissors cuts Paper and decapitates Lizard "); 
            Console.WriteLine("Paper covers Rock and disproves Spock");
            Console.WriteLine("Lizard poisons Spock and eats Paper");
            Console.WriteLine("Spock smashes Scissors and vaporizes Rock");
            Console.WriteLine("LET THE BATTLE BEGIN!");

            //Choose game type - PvP or PvComputer
            ChooseGameMode();

            //Optional setup - Choose Rounds? Enter player names?

            int playerOnePoints = 0;
            int playerTwoPoints = 0;

            //Gameplay Rounds Section
            //Display current state of game points
            //Display gesture options
            //Player One Chooses a gesture
            for (int games = 0; games <= 3; games++)
            {


                string playerOnesChoice = playerOne.ChooseGesture();
                string playerTwosChoice = playerTwo.ChooseGesture();


                if (playerOnesChoice.Equals(playerTwosChoice))
                {
                    Console.WriteLine("Tie Round");

                }
                else if (playerOnesChoice.Equals("Rock"))
                {
                    if (playerTwosChoice.Equals("Paper"))
                    {
                        Console.WriteLine("Paper covers Rock, Player Two wins round!");
                        playerTwoPoints++;

                    }
                    else if (playerTwosChoice.Equals("Scissors"))
                    {
                        Console.WriteLine("Rock covers Scissors, Player One wins round!");
                        playerOnePoints++;
                    }
                    else if (playerTwosChoice.Equals("Lizard"))
                    {
                        Console.WriteLine("Rock crushes Lizard, Player One wins round!");
                        playerOnePoints++;
                    }
                    else if (playerTwosChoice.Equals("Spock"))
                    {
                        Console.WriteLine("Spock vaporizes Rock, Player Two wins round!");
                        playerTwoPoints++;
                    }
                }
                else if (playerOnesChoice.Equals("Paper"))
                {
                    if (playerTwosChoice.Equals("Rock"))
                    {
                        Console.WriteLine("Paper covers Rock, Player One wins round!");
                        playerOnePoints++;
                    }
                    else if (playerTwosChoice.Equals("Scissors"))
                    {
                        Console.WriteLine("Scissors cuts Paper, Player Two wins round!");
                        playerTwoPoints++;
                    }
                    else if (playerTwosChoice.Equals("Lizard"))
                    {
                        Console.WriteLine("Lizard eats paper, Player Two wins round!");
                        playerTwoPoints++;
                    }
                    else if (playerTwosChoice.Equals("Spock"))
                    {
                        Console.WriteLine("Paper disproves Spock, Player One wins round!");
                        playerOnePoints++;
                    }
                }
                else if (playerOnesChoice.Equals("Scissors"))
                {
                    if (playerTwosChoice.Equals("Lizard"))
                    {
                        Console.WriteLine("Scissors decapitates Lizard, Player One wins round!");
                        playerOnePoints++;
                    }
                    else if (playerTwosChoice.Equals("Spock"))
                    {
                        Console.WriteLine("Spock smashes Scissors, Player Two wins round!");
                        playerTwoPoints++;
                    }
                    else if (playerTwosChoice.Equals("Rock"))
                    {
                        Console.WriteLine("Rock covers Scissors, Player Two wins round!");
                        playerTwoPoints++;
                    }
                    else if (playerTwosChoice.Equals("Paper"))
                    {
                        Console.WriteLine("Scissors covers Paper, Player One wins round!");
                        playerOnePoints++;
                    }

                }
                else if (playerOnesChoice.Equals("Lizard"))
                {
                    if (playerTwosChoice.Equals("Rock"))
                    {
                        Console.WriteLine("Rock crushes Lizard, Player Two wins round!");
                        playerTwoPoints++;
                    }
                    else if (playerTwosChoice.Equals("Paper"))
                    {
                        Console.WriteLine("Lizard eats Paper, Player One wins round!");
                        playerOnePoints++;
                    }
                    else if (playerTwosChoice.Equals("Scissors"))
                    {
                        Console.WriteLine("Scissors decapitates Lizard, Player Two wins round!");
                        playerTwoPoints++;
                    }
                    else if (playerTwosChoice.Equals("Spock"))
                    {
                        Console.WriteLine("Lizard poisons Spock, Player Two wins round!");
                        playerOnePoints++;
                    }
                }
                else if (playerOnesChoice.Equals("Spock"))
                {
                    if (playerTwosChoice.Equals("Paper"))
                    {
                        Console.WriteLine("Paper disproves Spock, Player Two wins round!");
                        playerTwoPoints++;
                    }
                    else if (playerTwosChoice.Equals("Scissors"))
                    {
                        Console.WriteLine("Spock smashes Scissors, Player One wins round!");
                        playerOnePoints++;
                    }
                    else if (playerTwosChoice.Equals("Lizard"))
                    {
                        Console.WriteLine("Lizard poisons Spock, Player Two wins round!");
                        playerTwoPoints++;
                    }
                    else if (playerTwosChoice.Equals("Rock"))
                    {
                        Console.WriteLine("Spock vaporizes Rock, Player Two wins round!");
                        playerOnePoints++;
                    }

                }

                Console.WriteLine("Player 1 points = " + playerOnePoints);
                Console.WriteLine("Player 2 points = " + playerTwoPoints);
                if ((playerOnePoints * 1.0) / 3 >= .5)
                {
                    Console.WriteLine("Player one wins!!");
                    break;

                }
                else if ((playerTwoPoints * 1.0) / 3 >= .5)
                {
                    Console.WriteLine("Player Twwo wins!!");
                    break;

                }
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
}
