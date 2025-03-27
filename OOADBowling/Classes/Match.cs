using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Classes
{
    public class Match
    {
        public Medlem Spelare1 { get; }
        public Medlem Spelare2 { get; }
        public Medlem Vinnare { get; private set; }

        public Match(Medlem spelare1, Medlem spelare2)
        {
            Spelare1 = spelare1;
            Spelare2 = spelare2;
        }

        public void BestämVinnare(int spelare1Poäng, int spelare2Poäng)
        {
            if (spelare1Poäng > spelare2Poäng)
                Vinnare = Spelare1;
            else if (spelare2Poäng > spelare1Poäng)
                Vinnare = Spelare2;
            else
                Vinnare = null;
        }
    }
}
