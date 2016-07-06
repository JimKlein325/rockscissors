using Xunit;
using System;

namespace RockScissors.Tests
{
  public class GameTest : IDisposable
  {
    [Fact]
    public void Play_InputsAreEqualRR_Draw()
    {
      //Arrange
      Game game = new Game(0,0);

      //Act
      Result result = game.PlayGame();

      // string name = Allergy.GetAllergyListString();

      //Assert
      Assert.Equal(Result.Draw, result);

    }
    [Fact]
    public void Play_InputsRockComputerScissors_Win()
    {
      //Arrange
      Game game = new Game(0,1);

      //Act
      Result result = game.PlayGame();

      // string name = Allergy.GetAllergyListString();

      //Assert
      Assert.Equal(Result.Win, result);

    }


    public void Dispose()
    {

    }
  }
}
