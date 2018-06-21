using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer()
        {
            this.name = "Computer";
            this.score = 0;
        }
    }
}
