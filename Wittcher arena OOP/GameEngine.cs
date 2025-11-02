
namespace Wittcher_arena_OOP
{
    internal class GameEngine
    {
        public GameEngine(Monster monster, Player player)
        {
            int round = 1;
            int winCount = 0;
            while (true)
            {

                while (player.CurrentHp > player.MinHp && monster.MonsterCurrentHP > monster.MonsterMinHP)
                {
                    int damageToPlayer = monster.MonsterAttack();
                    player.PlayerGetDamage(damageToPlayer);

                    int damageToMonster = player.PlayerAttack1();
                    monster.MonsterGetDamage(damageToMonster);

                    Console.WriteLine("pre boj zmackni nejaku klavesu");
                    Console.ReadKey();
                    Console.WriteLine($"Monster HP: {monster.MonsterCurrentHP}, Player HP: {player.CurrentHp}");
                }
                if (player.CurrentHp <= player.MinHp)

                {
                    Console.WriteLine("zomrel si lol");
                    break;

                }
                else if (monster.MonsterCurrentHP <= monster.MonsterMinHP)
                {

                    round++;
                    winCount += 1;

                    player.CurrentHp = player.CurrentHp + 50;
                    player.Inventory.AddItem("potion velkej sily");

                    monster.MonsterCurrentHP = monster.MonsterMaxHp;
                    Console.WriteLine($" okay zdolal si monstrum {monster.MonsterGetName()} Tvoje momentalne zdravie sa zvysilo o 50 a je teda :  {player.CurrentHp} Pocet vyhier : {winCount}");

                    if (player.Inventory.Contains("potion velkej sily"))
                    {
                        Console.WriteLine("Chceš otvoriť inventár [A/N] ?");
                        string invAnsw = Console.ReadLine()?.ToUpper() ?? "N";

                        if (invAnsw == "A")
                        {
                            Console.ReadKey();
                            Console.Clear();
                            player.Inventory.Print();

                            Console.WriteLine("\nChceš použiť potion velkej sily z inventára [A/N] ?");
                            string invUsePot = Console.ReadLine()?.ToUpper() ?? "N";

                            if (invUsePot == "A")
                            {
                                player.PlayerPotion();
                                player.Inventory.RemoveItem("potion velkej sily");
                                Console.WriteLine("Použil si potion ");
                                Console.WriteLine("Teraz mas o 5 hp viac  a o 15 % silnejsi utok");
                            }



                        }
                    }
                    monster.MonsterPowerPLus();
                    Console.WriteLine($"monstrum ma teraz {monster.MonsterCurrentHP} zivotov  a je silnejsie o 5%");
                    Console.WriteLine($"pre pokracovanie stlaxc nahodnu klavesu");
                    Console.ReadKey();
                    Console.Clear();

                }
            }
        }
    }
}

























































