using System;
using System.Collections.Generic;
using System.Text;


namespace RockScissors
{

  public enum Result {Win, Lose, Draw}
  public enum Play {Rock, Scissors, Paper}

  public class Game
  {
    private Play _play;
    private Play _computerPlay;


    public Game(int playerInput, int computerPlay)
    {
      switch (playerInput)
      {
        case 0:
        _play = Play.Rock;
        break;
        case 1:
        _play = Play.Scissors;
        break;
        case 2:
        _play = Play.Paper;
        break;
        default:
        break;
      }

      switch (computerPlay)
      {
        case 0:
        _computerPlay = Play.Rock;
        break;
        case 1:
        _computerPlay = Play.Scissors;
        break;
        case 2:
        _computerPlay = Play.Paper;
        break;
        default:
        break;
      }

    }
    public Result PlayGame(){
      if(_play == _computerPlay) return Result.Draw;
      
      return Result.Lose;
    }

    private Play GetComputersPlay(){
      return Play.Rock;
    }


  }
}
