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

        public override string Gesture()
        {
            bool continueLooping = true;
            while(continueLooping)
            {
                Console.WriteLine("\n" + name + " what gesture would you like to cast?");
                string theGesture;
                theGesture = Console.ReadLine();   
                listOfGestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
                for (int i = 0; i < listOfGestures.Count; i++)
                {
                    if (listOfGestures[i] == theGesture.ToLower())
                    {
                        gesture = listOfGestures[i];
                        continueLooping = false;
                    }
                }
            }
            Console.WriteLine("\n" + name + " casted: " + gesture);
            return gesture;
        }
    }
}
