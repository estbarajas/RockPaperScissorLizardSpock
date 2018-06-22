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

        public string setName()
        {
            Console.WriteLine("Enter a name for the player");
            string test = Console.ReadLine();
            return test;
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

        public string Gesture(string passedGesture)
        {
            string foundTheWord = "llun";
            listOfGestures = new List<string>() {"rock", "paper", "scissors", "lizard", "spock"};
            for (int i = 0; i < listOfGestures.Count; i++)
            {
                if (listOfGestures[i] == passedGesture.ToLower())
                {
                    //Console.WriteLine("Found the word " + listOfGestures[i] + " in index " + i);
                    foundTheWord = listOfGestures[i];
                }
            }
            //Console.WriteLine("Found the word in list" + foundTheWord);
            return foundTheWord;
        }
    }
}
