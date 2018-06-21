using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Game
    {
        public Player theHuman;
        public Player theComputer;
        public double winCondition;
        public string numberOfPlayers;

        public Game()
        {
            winCondition = 2;
        }

        public void MainMenu()
        {
            SetPlayers();
        }

        public void SetPlayers() //initiate the player objects
        {
            Console.WriteLine("Is there one player or two? \nA) One \nB) Two" );
            numberOfPlayers = Console.ReadLine();
            if (numberOfPlayers == "a")
            {
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

        }
    }
}
