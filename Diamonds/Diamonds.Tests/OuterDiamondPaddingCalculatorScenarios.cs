using Diamonds.Domain;
using Xunit;

namespace Diamonds.Tests {
  public class OuterDiamondPaddingCalculatorScenarios
  {
    private const char DiamondLetter = 'F';

    [Fact]
    public void letter_F_returns_paddingLeft_0()
    {
      var letter = 'F';
      var diamondPadding = new OuterDiamondPaddingCalculator();
      int paddingLeft = diamondPadding.Get(DiamondLetter, letter);
      Assert.Equal(0, paddingLeft);
    }

    [Fact]
    public void letter_C_for_diamond_F_returns_paddingLeft_3()
    {
      var letter = 'C';
      var diamondPadding = new OuterDiamondPaddingCalculator();
      int paddingLeft = diamondPadding.Get(DiamondLetter, letter);
      Assert.Equal(3, paddingLeft);
    }

    [Fact]
    public void letter_D_for_diamond_F_returns_paddingLeft_2()
    {
      var letter = 'D';
      var diamondPadding = new OuterDiamondPaddingCalculator();
      int paddingLeft = diamondPadding.Get(DiamondLetter, letter);
      Assert.Equal(2, paddingLeft);
    }

    [Fact]
    public void letter_A_for_diamond_F_returns_paddingLeft_6()
    {
      var letter = 'A';
      var diamondPadding = new OuterDiamondPaddingCalculator();
      int paddingLeft = diamondPadding.Get(DiamondLetter, letter);
      Assert.Equal(6, paddingLeft);
    }
  }
}
