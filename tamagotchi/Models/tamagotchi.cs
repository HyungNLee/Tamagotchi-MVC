using System;
using System.Collections.Generic;

namespace Tamagotchis.Models
{
  public class Tamagotchi
  {
    public string Name {get; set;}
    public int Hunger {get; set;}
    public int Energy {get; set;}
    public int Attention {get; set;}
    private static List<Tamagotchi> _toys = new List<Tamagotchi> {};

    public Tamagotchi(string name)
    {
      Name = name;
      Hunger = 100;
      Energy = 100;
      Attention = 100;
      _toys.Add(this);
    }

    public void Feed()
    {
      Hunger += 30;
    }

    public void Rest()
    {
      Energy += 30;
    }

    public void Play()
    {
      Attention += 30;
    }

    public static List<Tamagotchi> GetAll()
    {
      return _toys;
    }

  }
}
