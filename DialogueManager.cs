class DialogueManager
{
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
    int selection;
    while (!int.TryParse(Console.ReadLine(), out selection))
    {
      Console.Write($"This is not valid input. Please enter a number: ");
    }
    int next = text.options[selection - 1].next;
    if (next == 0)
    {
      Console.Clear();
      Environment.Exit(0);
    }
    Read(next);
  }
}
