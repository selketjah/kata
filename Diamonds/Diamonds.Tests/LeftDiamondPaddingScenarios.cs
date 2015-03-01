using Diamonds.Domain;
using Xunit;

namespace Diamonds.Tests {
  public class LeftDiamondPaddingScenarios
  {
    private const char DiamondLetter = 'F';

    [Fact]
    public void letter_F_returns_paddingLeft_0()
    {
      var letter = 'F';
      var diamondPadding = new LeftDiamondPadding(DiamondLetter);
      int paddingLeft = diamondPadding.GetLeft(letter);
      Assert.Equal(0, paddingLeft);
    }

    [Fact]
    public void letter_C_for_diamond_F_returns_paddingLeft_3()
    {
      var letter = 'C';
      var diamondPadding = new LeftDiamondPadding(DiamondLetter);
      int paddingLeft = diamondPadding.GetLeft(letter);
      Assert.Equal(3, paddingLeft);
    }

    [Fact]
    public void letter_A_for_diamond_F_returns_paddingLeft_6()
    {
      var letter = 'A';
      var diamondPadding = new LeftDiamondPadding(DiamondLetter);
      int paddingLeft = diamondPadding.GetLeft(letter);
      Assert.Equal(6, paddingLeft);
    }
  }
}
