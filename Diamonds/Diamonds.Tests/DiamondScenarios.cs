using FsCheck.Fluent;
using Xunit;

namespace Diamonds.Tests
{
    public class DiamondScenarios
    {
      [Fact]
      public void Does_not_return_empty_string()
      {
        var diamond = new Diamond();
        var result = diamond.Make('A');
        Assert.NotEmpty(result);
      }

      [Fact]
      public void First_row_contains_A()
      {
        
      }
    }

  public class Diamond
  {
    public string Make(char letter)
    {
      return "*";
    }
  }
}
