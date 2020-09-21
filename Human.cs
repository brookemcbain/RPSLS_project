using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Human : Player
    {
        public Human()
        {

        }
        public override string ChooseGesture()
        {
            while (true)
            {
                Console.WriteLine("Please choose which object you'd like to play? ");
                Console.WriteLine("1: ROCK ");
                Console.WriteLine("2: PAPER ");
                Console.WriteLine("3: SCISSORS");
                Console.WriteLine("4: LIZARD ");
                Console.WriteLine("5: SPOCK ");


                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        return objectList[0];
                    case "2":
                        return objectList[1];
                    case "3":
                        return objectList[2];
                    case "4":
                        return objectList[3];
                    case "5":
                        return objectList[4];
                    default:
                        Console.WriteLine("Invalid option, please give an answer 1-5");
                        break;

                }
            }

        }
    }
}
