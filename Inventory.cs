class Inventory
{
  private List<Item> items = new List<Item>();

  public List<Item> GetItems() => items;

  public void AddItem(Item item, int qty = 1)
  {
    Item existingItem = items.Find((i) => i.name == item.name);
    if (existingItem != null)
    {
      existingItem.qty += qty;
    }
    else
    {
      item.qty = qty;
      items.Add(item);
    }
  }

  public void RemoveItem(Item item, int qty = 1)
  {
    Item existingItem = items.Find((i) => i.name == item.name);
    if (existingItem.qty - qty <= 0)
    {
      items.Remove(existingItem);
    }
    else
    {
      existingItem.qty -= qty;
    }
  }
}
