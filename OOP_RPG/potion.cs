using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class potion : IItem
    {
        public int HP { get; set; }
        public string NAME { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }

        public potion(string Name, int HP, int originalvalue, int resellvalue)
        {
            this.NAME = Name;
            this.HP = HP;
            this.ResellValue = resellvalue;
            this.OriginalValue = originalvalue;
        }
    }
}
