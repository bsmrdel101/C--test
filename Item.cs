enum DamageType
{
  Slashing,
  Piercing,
  Bludgeoning
}

class Item
{
  public string name;
  public int damage = 0;
  public DamageType damageType;

  public Item(string name, int damage, DamageType damageType)
  {
    this.name = name;
    this.damage = damage;
    this.damageType = damageType;
  }
}
