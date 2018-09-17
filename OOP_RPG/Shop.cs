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


        public Shop()
        {
            this.weapon = new List<Weapon>();
            this.armor = new List<Armor>();
            this.potion = new List<potion>();

            weapon.Add(new Weapon("Sword", 10, 2, 3));
            weapon.Add(new Weapon("Axe", 12, 3, 4));
            weapon.Add(new Weapon("Longsword", 20, 5, 7));
            armor.Add(new Armor(" Wooden Armor", 10, 2, 3));
            armor.Add(new Armor("Metal Armor", 20, 5, 7));
            potion.Add(new potion("Healing Potion", 5, 5, 2));
        }


    }
}