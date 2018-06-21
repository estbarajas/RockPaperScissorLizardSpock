using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorLizardSpock
{
    class Human: Player
    {
        public Human(string name)
        {
            this.name = name;
            this.score = 0;
        }
    }
}
