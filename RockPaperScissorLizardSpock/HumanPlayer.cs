using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string name)
        {
            this.name = name;
            this.score = 0;
        }
    }
}
