using Xunit;
using System;

namespace RockScissors
{
  public class FindReplaceTest : IDisposable
  {
    [Fact]
    public void Find_WholeWordBob_Bob()
    {
      //Arrange
      FindReplace finder = new FindReplace();
      //Act
      bool result = finder.Find("Hi Bob!", "Bob");
      //Assert
      Assert.Equal(true, result);
    }
    [Fact]
    public void Replace_WholeWordBart_HiBart()
    {
      //Arrange
      FindReplace finder = new FindReplace();
      //Act
      string result = finder.Replace("Hi Bob!", "Bob", "Bart");
      //Assert
      Assert.Equal("Hi Bart!", result);
    }
    [Fact]
    public void Replace_WholeWordBart_HiBartYoureaBartcat()
    {
      //Arrange
      FindReplace finder = new FindReplace();
      //Act
      string result = finder.Replace("Hi Bob! You're a Bobcat!", "Bob", "Bart");
      //Assert
      Assert.Equal("Hi Bart! You're a Bartcat!", result);
    }
    [Fact]
    public void Replace_WholeWordBart_HiBartYoureabartcat()
    {
      //Arrange
      FindReplace finder = new FindReplace();
      //Act
      string result = finder.ReplaceMultiple("Hi BoB! You're a bobcat", "bob", "bart");
      //Assert
      Assert.Equal("Hi bart! You're a bartcat", result);
    }


    public void Dispose()
    {

    }
  }
}
