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
  }
}
