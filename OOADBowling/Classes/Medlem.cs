using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Classes
{
    public class Medlem
    {
        public string Namn { get; set; }
        public int Id { get; set; }

        public Medlem(string namn, int id)
        {
            Namn = namn;
            Id = id;
        }
    }
}
