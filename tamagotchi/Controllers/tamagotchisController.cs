using Microsoft.AspNetCore.Mvc;
using Tamagotchis.Models;
using System.Collections.Generic;

namespace Tamagotchis.Controllers
{
  public class TamagotchisController : Controller
  {
    [HttpGet("/add")]
    public ActionResult Add()
    {
      return View();
    }

    [HttpPost("/show")]
    public ActionResult Show()
    {
      Tamagotchi newToy = new Tamagotchi(Request.Form["new-name"]);
      List<Tamagotchi> allToys = Tamagotchi.GetAll();
      return View("Show", allToys);
    }

    [HttpGet("/show")]
    public ActionResult ShowBase()
    {
      List<Tamagotchi> allToys = Tamagotchi.GetAll();
      return View("Show", allToys);
    }

    [HttpGet("/show/{id}")]
    public ActionResult Show(int id)
    {
      List<Tamagotchi> allToys = Tamagotchi.GetAll();
      int find = id - 1;
      return View("ShowID", allToys[find]);
    }

    [HttpPost("/show/{id}/feed")]
    public ActionResult Feed(int id)
    {
      List<Tamagotchi> allToys = Tamagotchi.GetAll();
      int find = id - 1;
      allToys[find].Feed();
      return View ("ShowID", allToys[find]);
    }

    [HttpPost("/show/{id}/play")]
    public ActionResult Play(int id)
    {
      List<Tamagotchi> allToys = Tamagotchi.GetAll();
      int find = id - 1;
      allToys[find].Play();
      return View ("ShowID", allToys[find]);
    }

    [HttpPost("/show/{id}/rest")]
    public ActionResult Rest(int id)
    {
      List<Tamagotchi> allToys = Tamagotchi.GetAll();
      int find = id - 1;
      allToys[find].Rest();
      return View ("ShowID", allToys[find]);
    }

    [HttpPost("/show/{id}/time")]
    public ActionResult Time(int id)
    {
      List<Tamagotchi> allToys = Tamagotchi.GetAll();
      int find = id - 1;
      allToys[find].SimTime();
      return View ("ShowID", allToys[find]);
    }
  }
}
