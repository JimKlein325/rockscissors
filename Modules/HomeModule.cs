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
        Console.WriteLine(playerinput.ToString());
        var game = new Game(playerinput);
        return View["index.cshtml", game];
      };

    }
  }
}
