

namespace Wittcher_arena_OOP
{
    public class Monster


    {
        private string MonsterName = "";
        public void MonsterSetName(string? MonstName)
        {
            MonsterName = MonstName;
        }
        public string MonsterGetName()
        {
            return MonsterName;

        }


        public int MonsterMaxHp = 100;
        public int MonsterMinHP = 0;
        public int MonsterCurrentHP;
        public int MonsterAttackPower = 10;

        public void MonstCurrentHP()
        {
            MonsterCurrentHP = MonsterMaxHp;

        }



        private Random random = new Random();


        public int MonsterGetDamage(int damage)
        {
            MonsterCurrentHP -= damage;
            if (MonsterCurrentHP < MonsterMinHP)
                MonsterCurrentHP = MonsterMinHP;
            return MonsterCurrentHP;
        }
        public int MonsterAttack()
        {
            int damage = (int)(MonsterAttackPower * (random.Next(80, 121) / 100.0));
            return damage;
        }
        public void MonsterPowerPLus()
        {
            MonsterMaxHp = (int)(MonsterMaxHp * 1.05);
            MonsterAttackPower = (int)(MonsterAttackPower * 1.05);
            MonsterCurrentHP = MonsterMaxHp;
        }
    }

    
}


          