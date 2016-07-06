using System;
using System.Collections.Generic;
using System.Text;


namespace RockScissors
{

  public enum Result { Win, Lose, Draw}
  public enum Play {Rock, Scissors, Paper}

  public class Game
  {
    private Play _play;
    private Play _computerPlay;
    private  bool _isInitialState;


    public Game ()
    {
      _isInitialState = true;
    }

    public Game(int playerInput)
    {
      _play = GetPlayValue(playerInput);

      SetComputerPlayer();

      _isInitialState = false;

    }

    private void SetValues(int playerinput, int computerinput)
    {
      _play = GetPlayValue(playerinput);
      _computerPlay = GetPlayValue(computerinput);
    }
    private Play GetPlayValue(int value)
    {
      switch (value)
      {
        case 0:
        return Play.Rock;

        case 1:
        return Play.Paper;

        default:
        return Play.Scissors;
      }
    }

    private void SetComputerPlayer()
    {
      Random random = new Random();
      int randomPlay = random.Next(3);
      _computerPlay = GetPlayValue(randomPlay);
    }

    public Play GetPlayerInput()
    {
      return _play;
    }
    public Play GetComputerPlay()
    {
      return _computerPlay;
    }
    public  bool IsInitialState()
    {
      return _isInitialState;
    }

    public Result PlayGame(int playerinput, int computerinput){
      SetValues (playerinput, computerinput);

      if(_play == _computerPlay) return Result.Draw;

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

    }
  }
}
