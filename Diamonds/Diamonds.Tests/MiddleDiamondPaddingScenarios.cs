using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Diamonds.Tests {
  public class MiddleDiamondPaddingScenarios {

    [Fact]
    public void char_F_returns_middlePadding_11()
    {
      var letter = 'F';
      var middleDiamondPadding = new MiddleDiamondPadding();
      var result = middleDiamondPadding.Get(letter);
      Assert.Equal(11, result);
    }
  }

  public class MiddleDiamondPadding
  {
    public int Get(char letter)
    {
      return 11;
    }
  }
}
