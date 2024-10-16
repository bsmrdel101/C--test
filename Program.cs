Console.Clear();
Console.WriteLine("Enter your name:");
string playerName = Console.ReadLine();
Player player = new Player(playerName);
Inventory inventory = new Inventory();

Item sword = new Item("Sword", 6, DamageType.Slashing);
Item dagger = new Item("Dagger", 3, DamageType.Piercing);

new DialogueManager(inventory).Start();
