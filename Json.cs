using System.Text.Json;

static class Json
{
  static public Text GetDialogue(int id)
  {
    string fileName = $"./dialogue/dialogue.json";
    string jsonString = File.ReadAllText(fileName);
    Text[] data = JsonSerializer.Deserialize<Text[]>(jsonString);
    foreach (Text text in data)
    {
      if (text.id == id) return text;
    }
    return data[0];
  }
}

struct Text
{
  public int id { get; set; }
  public string main { get; set; }
  public Option[] options { get; set; }
}

struct Option
{
  public string text { get; set; }
  public int next { get; set; }
  public Event[] events { get; set; }
}

struct Event
{
  public string name { get; set; }
  public EventData data { get; set; }
}

struct EventData
{
  public string name { get; set; }
  public int qty { get; set; }
  public int dmg { get; set; }
  public string dmgType { get; set; }
}
