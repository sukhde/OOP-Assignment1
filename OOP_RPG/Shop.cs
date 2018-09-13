using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Shop
    {

        public List<Weapon> weapon { get; set; }
        public List<Armor> armor { get; set; }
        public List<potion> potion { get; set; }

        public Shop(){
            this.weapon = new List<Weapon>();
            this.armor = new List<Armor>();
            this.potion = new List<potion>();
            }
    }
}
