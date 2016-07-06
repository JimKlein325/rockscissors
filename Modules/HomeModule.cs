using Nancy;
using System.Collections.Generic;
using System;

namespace RockScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var game = new Game();
        return View["index.cshtml", game];
      };
      Post["/play"] = _ => {
        int playerinput = Request.Form["RockScissors"];
        var game = new Game(playerinput);
        Console.WriteLine(game.GetComputerPlay().ToString());
        return View["index.cshtml", game];
      };

    }
  }
}
