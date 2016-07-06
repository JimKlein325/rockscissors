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
      Game game = new Game();


      //Act
      Result result = game.PlayGame(0,0);

      // string name = Allergy.GetAllergyListString();

      //Assert
      Assert.Equal(Result.Draw, result);

    }
    [Fact]
    public void Play_InputsRockComputerScissors_Win()
    {
      //Arrange
      Game game = new Game();

      //Act
      Result result = game.PlayGame(0,1);

      // string name = Allergy.GetAllergyListString();

      //Assert
      Assert.Equal(Result.Win, result);

    }
    [Fact]
    public void Play_InputsRockComputerPaper_Lose()
    {
      //Arrange
      Game game = new Game();

      //Act
      Result result = game.PlayGame(0,2);

      // string name = Allergy.GetAllergyListString();

      //Assert
      Assert.Equal(Result.Lose, result);

    }

    public void Dispose()
    {

    }
  }
}
