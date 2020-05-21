using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGGame.Models
{
    public class Hero
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public byte Alive { get; set; }
        public virtual Weapon HeroWeapon { get; set; }
    }
}
