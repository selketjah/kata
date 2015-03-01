using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Diamonds.Tests {
  public class DiamondPaddingScenarios {

    [Fact]
    public void letter_F_returns_paddingLeft_0()
    {
      var letter = 'F';
      var diamondPadding = new DiamondPadding();
      int paddingLeft = diamondPadding.GetLeft(letter);
      Assert.Equal(0, paddingLeft);
    }
  }

  public class DiamondPadding
  {
    public int GetLeft(char letter)
    {
      return 0;
    }
  }
}
