class DialogueManager
{
  private Inventory inventory;

  public DialogueManager(Inventory inventory)
  {
    this.inventory = inventory;
  }

  public void Start()
  {
    Read(0);
  }

  private void Read(int id)
  {
    Console.Clear();
    Text text = Json.GetDialogue(id);
    Console.WriteLine(text.main);
    Console.WriteLine("");
    for (int i = 0; i < text.options.Length; i++)
    {
      Console.WriteLine($"{i + 1}) {text.options[i].text}");
    }
    int selection = int.Parse(Console.ReadLine());
    int next = text.options[selection - 1].next;
    Event[] events = text.options[selection - 1].events;

    if (events != null)
    {
      foreach (Event e in events)
      {
        if (e.name == "AddItem")
        {
          Enum.TryParse(e.data.dmgType, out DamageType dmgType);
          Item sword = new Item(e.data.name, e.data.dmg, dmgType);
          inventory.AddItem(sword, e.data.qty);
        }
      }
      Console.Clear();
      Console.WriteLine("Inventory:");
      Console.WriteLine("");
      foreach (Item item in inventory.GetItems())
      {
        Console.WriteLine($"{item.qty} {item.name} ({item.damage} {item.damageType})");
      }
      Console.WriteLine("");
      Console.WriteLine("Press enter to close inventory:");
      Console.ReadLine();
    }

    if (next == 0)
    {
      Console.Clear();
      Environment.Exit(0);
    }
    Read(next);
  }
}
