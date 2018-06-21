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
        public string numberOfPlayers;


        public Game()
        {
            setPlayers();
            
        }

        public void setPlayers()
        {
            Console.WriteLine("Is there one player or two? \nA) One \nB) Two" );
            numberOfPlayers = Console.ReadLine();
            if (numberOfPlayers == "a")
            {

            }
            else if (numberOfPlayers == "a")
            {

            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

        }
    }
}
