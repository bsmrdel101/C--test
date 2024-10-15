Console.Clear();
Console.WriteLine("Enter your name:");
string playerName = Console.ReadLine();
Player player = new Player(playerName);

new DialogueManager().Start();
