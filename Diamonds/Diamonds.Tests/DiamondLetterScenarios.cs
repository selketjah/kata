using Diamonds.Domain;
using Xunit;

namespace Diamonds.Tests {
  public class DiamondLetterScenarios {
    private const char DiamondLetter = 'F';

    [Fact]
    public void Given_a_char_F_returns_row_with_innerPadding_11() {
      var letter = 'F';
      var shouldBe = "F           F";
      var middleDiamondPadding = new DiamondLetter(letter);
      var result = middleDiamondPadding.GetRow(DiamondLetter);
      Assert.Equal(result, shouldBe);
    }

    [Fact]
    public void Given_a_char_C_returns_row_with_innerPadding_5_and_outerpadding_3() {
      var letter = 'C';
      var shouldBe = "   C     C   ";
      var middleDiamondPadding = new DiamondLetter(letter);
      var result = middleDiamondPadding.GetRow(DiamondLetter);
      Assert.Equal(result, shouldBe);
    }


    [Fact]
    public void Given_a_char_A_returns_row_with_outerpadding_6() {
      var letter = 'A';
      var shouldBe = "      A      ";
      var middleDiamondPadding = new DiamondLetter(letter);
      var result = middleDiamondPadding.GetRow(DiamondLetter);
      Assert.Equal(result, shouldBe);
    }
  }
}
