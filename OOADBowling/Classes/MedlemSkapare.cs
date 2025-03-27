using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Classes
{
    // MedlemSkapare använder Factory Pattern för att skapa Medlem-objekt
    public static class MedlemSkapare
    {
        private static int NextId = 1;

        public static Medlem SkapaMedlem(string namn)
        {
            return new Medlem(namn, NextId++); // Skapar och returnerar ett nytt Medlem-objekt
        }
    }
}
