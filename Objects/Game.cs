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



      if(_play == Play.Rock && _computerPlay == Play.Scissors) return Result.Win;

      switch(_play)
      {
        case Play.Rock:
        if(_computerPlay == Play.Scissors)
        {
          return Result.Win;
        } else {
          return Result.Lose;
        }

        case Play.Scissors:
        if(_computerPlay == Play.Paper)
        {
          return Result.Win;
        } else {
          return Result.Lose;
        }
        case Play.Paper:
        if(_computerPlay == Play.Rock)
        {
          return Result.Win;
        } else {
          return Result.Lose;
        }

        default:
          return Result.Draw;
      }
      return Result.Draw;
    }

    private Play GetComputersPlay(){
      return Play.Rock;
    }


  }
}
