using System;
using System.Collections.Generic;

namespace Tamagotchis.Models
{
  public class Tamagotchi
  {
    public string name {get; set;}
    public int hunger {get; set;}
    public int energy {get; set;}
    public int attention {get; set;}
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
      hunger += 30;
    }

    public void Rest()
    {
      energy += 30;
    }

    public void Play()
    {
      attention += 30;
    }

    public static List<Tamagotchi> GetAll()
    {
      return _toys;
    }

  }
}
