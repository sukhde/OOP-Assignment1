using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class potion
    {
        public int HP { get; set; }
        public string NAME { get; set; }
        public potion(string Name, int HP)
        {
            this.NAME = Name;
            this.HP = HP;
        }
    }
}
