using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP_RPG
{
    public class Fight
    {
        List<Monster> Monsters { get; set; }
        public Game game { get; set; }
        public Hero hero { get; set; }
        public Monster monster { get; set; }
        
        public Fight(Hero hero, Game game) {
            this.Monsters = new List<Monster>();
            this.hero = hero;
            this.game = game;
            this.AddMonster("Squid", 9, 8, 20);
            this.AddMonster("Nord", 5, 7, 10);
            this.AddMonster("Bonmer", 6, 3, 15);
            this.AddMonster("Donnde", 6, 4, 18);
            var enemy = this.Monsters[0];
            var Secondenemy = this.Monsters.ElementAt(1);
            var Lastenemy = this.Monsters.LastOrDefault();
            var firstMonster = (from s in this.Monsters
                                where s.CurrentHP < 20
                                select s).First();
            var randomEnemy = Monsters.OrderBy(s => Guid.NewGuid()).FirstOrDefault();
            var firstMonsterStrength = (from s in this.Monsters
                                        where s.Strength >= 11
                                        select s).FirstOrDefault();
            
            this.monster = randomEnemy;
        }
        
        public void AddMonster(string name, int strength, int defense, int hp) {
            var monster = new Monster(name,strength,defense,hp);
            
            this.Monsters.Add(monster);
        }
        
        public void Start() {
          
            Console.WriteLine("You've encountered a " + monster.Name + "! " + monster.Strength + " Strength/" + monster.Defense + " Defense/" + 
            monster.CurrentHP + " HP. What will you do?");
            Console.WriteLine("1. Fight");
            var input = Console.ReadLine();
            if (input == "1") {
                this.HeroTurn();
            }
            else { 
                this.game.Main();
            }
        }
        
        public void HeroTurn(){
          
           var compare = hero.Strength - monster.Defense;
           int damage;
           
           if(compare <= 0) {
               damage = 1;
                monster.CurrentHP -= damage;
           }
           else{
               damage = compare;
                monster.CurrentHP -= damage;
           }
           Console.WriteLine("You did " + damage + " damage!");
           
           if(monster.CurrentHP <= 0){
               this.Win();
           }
           else
           {
               this.MonsterTurn();
           }
           
        }
        
        public void MonsterTurn(){
           int damage;
           var compare = monster.Strength - hero.Defense;
           if(compare <= 0) {
               damage = 1;
               hero.CurrentHP -= damage;
           }
           else{
               damage = compare;
               hero.CurrentHP -= damage;
           }
           Console.WriteLine(monster.Name + " does " + damage + " damage!");
           if(hero.CurrentHP <= 0){
               this.Lose();
           }
           else
           {
               this.Start();
           }
        }
        
        public void Win() {
            Console.WriteLine(monster.Name + " has been defeated! You win the battle!");
            game.Main();
        }
        
        public void Lose() {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            return;
        }
        
    }
    
}