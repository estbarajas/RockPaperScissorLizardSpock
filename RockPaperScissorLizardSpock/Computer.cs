using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Computer : Player
    {
        List<string> listOfGestures;
        public Computer()
        {
            this.name = "Computer";
            this.score = 0;
        }

        public override string Gesture(string passedGesture)
        {
            listOfGestures = new List<string>() {"rock", "paper", "scissors", "lizard", "spock"};
            Random random = new Random();
            int randomIndex = random.Next(0, 5);
            Console.WriteLine("ITS UHHH: FOR COMPUTER: " + listOfGestures[randomIndex]);
            return listOfGestures[randomIndex];
        }
    }
}
