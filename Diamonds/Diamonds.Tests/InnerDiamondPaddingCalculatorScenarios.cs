using Diamonds.Domain;
using Xunit;

namespace Diamonds.Tests {
  public class InnerDiamondPaddingCalculatorScenarios {
    private const char DiamondLetter = 'F';

    [Fact]
    public void char_F_returns_middlePadding_11()
    {
      var letter = 'F';
      var middleDiamondPadding = new InnerDiamondPaddingCalculator(letter);
      var result = middleDiamondPadding.Get(DiamondLetter);
      Assert.Equal(11, result);
    }

    [Fact]
    public void char_C_returns_middlePadding_5()
    {
      var letter = 'C';
      var middleDiamondPadding = new InnerDiamondPaddingCalculator(letter);
      var result = middleDiamondPadding.Get(DiamondLetter);
      Assert.Equal(5, result);
    }

    [Fact]
    public void char_A_returns_middlePadding_0()
    {
      var letter = 'A';
      var middleDiamondPadding = new InnerDiamondPaddingCalculator(letter);
      var result = middleDiamondPadding.Get(DiamondLetter);
      Assert.Equal(0, result);
    }
  }
}
