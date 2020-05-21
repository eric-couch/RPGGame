using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGGame.Models
{
    public class Weapon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AttackValue { get; set; }
        public byte NumberOfHands { get; set; }
        public int AttackModifier { get; set; }

    }
}
