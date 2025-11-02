using Wittcher_arena_OOP;

Console.WriteLine(@"
 _    _      _                            _         
| |  | |    | |                          | |        
| |  | | ___| | ___ ___  _ __ ___   ___  | |_ ___   
| |/\| |/ _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  
\  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | 
 \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/  
                                                    
                                                    ");
Console.WriteLine(@"
    _       _      _    _ _ _       _                  ___                            _       _    
 /\| |/\ /\| |/\  | |  | (_) |     | |                / _ \                        /\| |/\ /\| |/\ 
 \ ` ' / \ ` ' /  | |  | |_| |_ ___| |__   ___ _ __  / /_\ \_ __ ___ _ __   __ _   \ ` ' / \ ` ' / 
|_     _|_     _| | |/\| | | __/ __| '_ \ / _ \ '__| |  _  | '__/ _ \ '_ \ / _` | |_     _|_     _|
 / , . \ / , . \  \  /\  / | || (__| | | |  __/ |    | | | | | |  __/ | | | (_| |  / , . \ / , . \ 
 \/|_|\/ \/|_|\/   \/  \/|_|\__\___|_| |_|\___|_|    \_| |_/_|  \___|_| |_|\__,_|  \/|_|\/ \/|_|\/ 
                                                                                                   
                                                                                                   ");
Console.WriteLine("\rGame Made By Alex Ozaniak \r");
 await Task.Delay(2500);
Console.Clear();
Console.WriteLine("Zdravim ta bojovnik, Prosim zadaj Svoje meno:");
string InputName = Console.ReadLine();
Player player = new Player();
player.SetName(InputName);
string MonstName = " David Developer";
Monster monster = new Monster();
monster.MonsterSetName(MonstName);
monster.MonstCurrentHP();

Console.WriteLine($" Dobre Bojovnik {player.GetName()} tak dufam ze si ready. prvy boj bude proti monstru s menom {monster.MonsterGetName()} ");
await Task.Delay(1200);




Console.Clear();
Console.WriteLine(@"
 _    ______ _____ _____  _   _ _____     _ 
| |   |  ___|_   _|  __ \| | | |_   _|   | |
| |   | |_    | | | |  \/| |_| | | |     | |
| |   |  _|   | | | | __ |  _  | | |     | |
|_|   | |    _| |_| |_\ \| | | | | |     |_|
(_)   \_|    \___/ \____/\_| |_/ \_/     (_)
                                            
                                             
                                    ");

// boj 1
GameEngine engine = new GameEngine(monster, player);











