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
        var result = diamond.Make("b");
        Spec.
      }
    }

  public class Diamond
  {
    public string[] Make(string letter)
    {
      throw new System.NotImplementedException();
    }
  }
}
