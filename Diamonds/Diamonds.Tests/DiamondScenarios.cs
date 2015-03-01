using Diamonds.Domain;
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
      public void First_row_contains_A() {
        var diamond = new Diamond();
        var result = diamond.Make('F');
        Assert.Equal(GetFirstRow(result), "A");
      }

      private string GetFirstRow(string result) {
        var resultArray = result.Split('\n');
        return resultArray[0].Trim();
      }
    }
}
