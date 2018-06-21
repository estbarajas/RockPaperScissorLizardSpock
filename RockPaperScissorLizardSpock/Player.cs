using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Player
    {
        public string name;
        public double score;

        public Player()
        {

        }

        public void getName()
        {
            Console.WriteLine("The player is named " + name + ".");
        }

        public void increaseScore()
        {
            score++;
            getScore();
        }

        public void getScore()
        {
            Console.WriteLine("The player " + name + " has a score of " + score + ".");
        }

    }
}
