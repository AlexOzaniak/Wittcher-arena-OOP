using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Wittcher_arena_OOP

{
    public class Player
    {
        string PlayerName = "";
        public void SetName(string? InputName)
        {
            PlayerName = InputName;
        }
        public string GetName()
        {
            return PlayerName;
        }


       public int MaxHP = 100;
        public int MinHp = 0;
        public int CurrentHp;
        public int PlayerAttack = 16;
        private Random random = new Random();
        public Inventory1 Inventory  = new Inventory1();






        public Player()
        {
            CurrentHp =  MaxHP;
        }

       
        public int PlayerAttack1()
        {
            int damage = (int)(PlayerAttack * (random.Next(80, 121) / 100.0));
            return damage;
        }
        private int GetDamage1(Monster monster)
        {
            return monster.MonsterAttack();
        }
        public int PlayerGetDamage(int damage)
        {
            CurrentHp -= damage;
            if (CurrentHp < MinHp) CurrentHp = MinHp;
            return CurrentHp;
        }

       

        public void PlayerPotion()
        {
           CurrentHp = (int)(CurrentHp + 5);
           PlayerAttack = (int)(PlayerAttack * 1.15);
           
        }










    }
}





