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
    private int _id;
    public string _picURL {get; set;}
    private static List<Tamagotchi> _toys = new List<Tamagotchi> {};
    private static int picNumber = 1;

    public Tamagotchi(string name)
    {
      Name = name;
      Hunger = 100;
      Energy = 100;
      Attention = 100;
      _toys.Add(this);
      _id = _toys.Count;
      if (picNumber < 6)
      {
        _picURL = GetPicture(picNumber);
        picNumber++;
      }
      else
      {
        picNumber = 1;
        _picURL = GetPicture(picNumber);
        picNumber++;
      }
    }

    public void SetHunger(int amount)
    {
      Hunger = amount;
    }

    public int GetHunger()
    {
      return Hunger;
    }

    public void Feed()
    {
      Hunger += 30;
      if (Hunger > 100)
      {
        Hunger = 100;
      }
    }

    public void Rest()
    {
      Energy += 30;
      if (Energy > 100)
      {
        Energy = 100;
      }
    }

    public void Play()
    {
      Attention += 30;
      if (Attention > 100)
      {
        Attention = 100;
      }
    }
    public int GetId()
    {
      return _id;
    }
    public void SimTime()
    {
      Hunger -= 10;
      Attention -= 6;
      Energy -= 3;
      if (CheckDead())
      {
        Console.WriteLine(Name + " is dead!");
        _picURL = "https://tshirt-factory.com/images/company/432/C_Simple_Skull.jpg";
      }
    }
    public bool CheckDead()
    {
      if (Hunger == 0 || Attention == 0 || Energy == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static List<Tamagotchi> GetAll()
    {
      return _toys;
    }
    private string GetPicture(int id)
    {
      if (id == 5)
      {
        return "http://bogleech.com/pokemon/allpokes/002Ivysaur.png";
      }
      else if (id == 4)
      {
        return "https://www.seeklogo.net/wp-content/uploads/2013/04/pokemon-anime-vector.png";
      }
      else if (id == 3)
      {
        return "https://i.pinimg.com/originals/31/4c/95/314c95fd708956690b48d473e94aea29.jpg";
      }
      else if (id == 2)
      {
        return "http://quovx4d83tr2hp1r22mgwa1m.wpengine.netdna-cdn.com/wp-content/uploads/2016/07/bewear-400x400.png";
      }
      else
      {
        return "https://assetsds.cdnedge.bluemix.net/sites/default/files/styles/big_6/public/news/images/pokemon_02.jpg?itok=dIUYs4TX";
      }
    }

  }
}
