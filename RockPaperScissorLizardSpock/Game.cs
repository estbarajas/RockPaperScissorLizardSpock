using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Game
    {
        public Player playerOne;
        public Player tplayerTwo;
        public double winCondition;
        public string numberOfPlayers;

        public Game()
        {
            winCondition = 2;
        }

        public void MainMenu()
        {
            SetPlayers(); //finish
            //theHuman = new Human("Juan"); //finish
            Console.WriteLine(playerOne.Gesture("SPOcK")); //finished
            Winner(playerOne.Gesture("rock"), playerOne.Gesture("paper"));
        }

        public void SetPlayers() //initiate the player objects
        {
            Console.WriteLine("Is there one player or two? \nA) One \nB) Two" );
            numberOfPlayers = Console.ReadLine();
            if (numberOfPlayers == "a")
            {
                playerOne = new Human("Juan");
                playerOne.getName();
                Console.WriteLine("Player Vs Computer");
            }
            else if (numberOfPlayers == "b")
            {
                Console.WriteLine("Player Vs Player");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        public void Winner(string playerOneGesture, string playerTwoGesture)
        {
            if (playerOneGesture == "rock")
            {
                if ((playerTwoGesture == "scissors") || (playerTwoGesture == "lizard"))
                {
                    Console.WriteLine("Human won");
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie tbvh");
                }
                else
                {
                    Console.WriteLine("Computer won");
                }
            }

            if (playerOneGesture == "paper")
            {
                if ((playerTwoGesture == "rock") || (playerTwoGesture == "spock"))
                {
                    Console.WriteLine("Human won");
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie tbvh");
                }
                else
                {
                    Console.WriteLine("Computer won");
                }
            }

            if (playerOneGesture == "scissors")
            {
                if ((playerTwoGesture == "paper") || (playerTwoGesture == "lizard"))
                {
                    Console.WriteLine("Human won");
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie tbvh");
                }
                else
                {
                    Console.WriteLine("Computer won");
                }
            }

            if (playerOneGesture == "lizard")
            {
                if ((playerTwoGesture == "spock") || (playerTwoGesture == "paper"))
                {
                    Console.WriteLine("Human won");
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie tbvh");
                }
                else
                {
                    Console.WriteLine("Computer won");
                }
            }

            if (playerOneGesture == "spock")
            {
                if ((playerTwoGesture == "scissors") || (playerTwoGesture == "rock"))
                {
                    Console.WriteLine("Human won");
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie tbvh");
                }
                else
                {
                    Console.WriteLine("Computer won");
                }
            }
        }
    }
}
