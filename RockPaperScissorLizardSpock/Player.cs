﻿using System;
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
        public string gesture;

        public string GetName()
        {
            return name;
        }

        public void IncreaseScore()
        {
            score++;
            GetScore();
        }

        public void GetScore()
        {
            Console.WriteLine("The player " + name + " has a score of " + score + ".");
        }

        public abstract string Gesture();
    }
}
