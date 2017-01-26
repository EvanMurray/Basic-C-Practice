using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Dice
    {
        public int sides {get; set;}

        public Dice() { }

        public Dice(int s)
        {
            sides = s;
        }
    }
}
