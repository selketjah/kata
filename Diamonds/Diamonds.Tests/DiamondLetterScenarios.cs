using Diamonds.Domain;
using Xunit;

namespace Diamonds.Tests {
  public class DiamondLetterScenarios {
    private const char DiamondLetter = 'F';

    [Fact]
    public void char_F_returns_innerPadding_11() {
      var letter = 'F';
      var middleDiamondPadding = new DiamondLetter('F');
      var result = middleDiamondPadding.GetInnerPadding(DiamondLetter);
      Assert.Equal(11, result);
    }

    [Fact]
    public void letter_F_returns_paddingLeft_0() {
      var letter = 'F';
      var diamondPadding = new DiamondLetter(letter);
      int paddingLeft = diamondPadding.GetOuterPadding(DiamondLetter);
      Assert.Equal(0, paddingLeft);
    }

    [Fact]
    public void char_C_returns_innerPadding_5() {
      var letter = 'C';
      var middleDiamondPadding = new DiamondLetter(letter);
      var result = middleDiamondPadding.GetInnerPadding(DiamondLetter);
      Assert.Equal(5, result);
    }

    [Fact]
    public void letter_C_for_diamond_F_returns_paddingLeft_3() {
      var letter = 'C';
      var diamondPadding = new DiamondLetter(letter);
      int paddingLeft = diamondPadding.GetOuterPadding(DiamondLetter);
      Assert.Equal(3, paddingLeft);
    }

    [Fact]
    public void char_A_returns_innerPadding_0() {
      var letter = 'A';
      var middleDiamondPadding = new DiamondLetter(letter);
      var result = middleDiamondPadding.GetInnerPadding(DiamondLetter);
      Assert.Equal(0, result);
    }

    [Fact]
    public void letter_A_for_diamond_F_returns_paddingLeft_6() {
      var letter = 'A';
      var diamondPadding = new DiamondLetter(letter);
      int paddingLeft = diamondPadding.GetOuterPadding(DiamondLetter);
      Assert.Equal(6, paddingLeft);
    }
  }
}
