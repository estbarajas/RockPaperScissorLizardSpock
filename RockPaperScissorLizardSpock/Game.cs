﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Game
    {
        public Player playerOne;
        public Player playerTwo;
        public double winCondition;
        public string numberOfPlayersOption;
        public double PlayerOneOrPlayerTwoMessageTracker;

        public Game()
        {
            winCondition = 2;
        }

        public void MainMenu()
        {
            Console.WriteLine("--Welcome to RPSLS!--");
            SetPlayers();
            GamePlay();
        }

        public void SetPlayers() 
        {
            bool continueLooping = true;
            while (continueLooping)
            {
                Console.WriteLine("\nWould you like to proceed to the one player mode or to the two player mode? \nA) One \nB) Two");
                numberOfPlayersOption = Console.ReadLine();
                if (numberOfPlayersOption.ToLower() == "a")
                {
                    EnterNameMessage(numberOfPlayersOption);
                    playerOne = new Human(Console.ReadLine());
                    playerTwo = new Computer();
                    continueLooping = false;
                }
                else if (numberOfPlayersOption.ToLower() == "b")
                {
                    EnterNameMessage(numberOfPlayersOption);
                    playerOne = new Human(Console.ReadLine());
                    EnterNameMessage(numberOfPlayersOption);
                    playerTwo = new Human(Console.ReadLine());
                    continueLooping = false;
                }
                else
                {
                    Console.WriteLine("Note: Invalid input.");
                }
            }   
        }

        public void EnterNameMessage(string option)
        {
            if (option.ToLower() == "a")
            {
                Console.WriteLine("\n[Player Vs Computer]");
                Console.WriteLine("Enter player one name:");
            }
            else if (option.ToLower() == "b")
            {
                if (PlayerOneOrPlayerTwoMessageTracker == 0)
                {
                    PlayerOneOrPlayerTwoMessageTracker++;
                    Console.WriteLine("\n[Player Vs Player]");
                    Console.WriteLine("Enter player one name:");
                }
                else if (PlayerOneOrPlayerTwoMessageTracker == 1)
                {
                    Console.WriteLine("Enter player two name:");
                }
            }
        }

        public void GamePlay()
        {
            do
            {
                Winner(playerOne.Gesture(), playerTwo.Gesture());
            } while ((playerOne.score < 2) && (playerTwo.score < 2));

            if ((playerOne.score >= 2))
            {
                Console.WriteLine("\n" + playerOne.GetName() + " has won the game!");
            }
            else if ((playerTwo.score <= 2))
            {
                Console.WriteLine("\n" + playerTwo.GetName() + " has won the game!");
            }
        }

        public void Winner(string playerOneGesture, string playerTwoGesture)
        {
            if (playerOneGesture == "rock")
            {
                if ((playerTwoGesture == "scissors") || (playerTwoGesture == "lizard"))
                {
                    Console.WriteLine("Winner: " + playerOne.GetName() + "!");
                    playerOne.IncreaseScore();
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("Winner: " + playerTwo.GetName() + "!");
                    playerTwo.IncreaseScore();
                }
            }
            else if (playerOneGesture == "paper")
            {
                if ((playerTwoGesture == "rock") || (playerTwoGesture == "spock"))
                {
                    Console.WriteLine("Winner: " + playerOne.GetName() + "!");
                    playerOne.IncreaseScore();
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("Winner: " + playerTwo.GetName() + "!");
                    playerTwo.IncreaseScore();
                }
            }
            else if (playerOneGesture == "scissors")
            {
                if ((playerTwoGesture == "paper") || (playerTwoGesture == "lizard"))
                {
                    Console.WriteLine("Winner: " + playerOne.GetName() + "!");
                    playerOne.IncreaseScore();
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("Winner: " + playerTwo.GetName() + "!");
                    playerTwo.IncreaseScore();
                }
            }
            else if (playerOneGesture == "lizard")
            {
                if ((playerTwoGesture == "spock") || (playerTwoGesture == "paper"))
                {
                    Console.WriteLine("Winner: " + playerOne.GetName() + "!");
                    playerOne.IncreaseScore();
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("Winner: " + playerTwo.GetName() + "!");
                    playerTwo.IncreaseScore();
                }
            }
            else if (playerOneGesture == "spock")
            {
                if ((playerTwoGesture == "scissors") || (playerTwoGesture == "rock"))
                {
                    Console.WriteLine("Winner: " + playerOne.GetName() + "!");
                    playerOne.IncreaseScore();
                }
                else if (playerOneGesture == playerTwoGesture)
                {
                    Console.WriteLine("Tie");
                }
                else
                {
                    Console.WriteLine("Winner: " + playerTwo.GetName() + "!");
                    playerTwo.IncreaseScore();
                }
            }
        }
    }
}
