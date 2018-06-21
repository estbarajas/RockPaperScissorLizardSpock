using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
   public abstract class Player
    {
        public string name;
        public double score;
        List<string> listOfGestures;


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

        public string Gesture(string passedGesture)
        {
            string foundTheWord = "llun";
            listOfGestures = new List<string>() {"Rock", "Paper", "Scissors", "Lizard", "Spock"};
            foreach(string gesture in listOfGestures)
            {
                if(passedGesture.Equals(gesture.ToLower()))
                {
                    foundTheWord = gesture;
                }
            }
            Console.WriteLine(foundTheWord);
            return foundTheWord;
        }

        public void Beats(Player player)
        {
            switch ("rock")
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
