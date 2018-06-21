using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Gesture
    {
        public Gesture()
        {

        }

        public void beats(string gesture)
        {
           switch (gesture.ToLower())
            {
                case "rock":
                    Console.WriteLine("");
                    break;
                case "paper":
                    Console.WriteLine("");
                    break;
                case "scissor":
                    Console.WriteLine("");
                    break;
                case "lizard":
                    Console.WriteLine("");
                    break;
                case "spock":
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Not a valid gesture.");
                    break;
            }
        }
    }
}
