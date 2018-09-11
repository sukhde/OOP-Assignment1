using System;
using System.Collections.Generic;

namespace OOP_RPG
{
    public class Monster
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }
        public int Gold { get; set; }

        public  Monster(string Name,int Strength, int Defense,int OriginalHP)
        {
            this.Name = Name;
            this.Strength = Strength;
            this.Defense = Defense;
            this.OriginalHP = OriginalHP;
            this.CurrentHP = OriginalHP;
            this.Gold = 5;
        }
    }
}