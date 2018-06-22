using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Human: Player
    {
        List<string> listOfGestures;
        public Human(string name)
        {
            this.name = name;
            this.score = 0;
        }

        public override string Gesture(string passedGesture)
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
