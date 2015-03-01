using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diamonds.Domain;
using Xunit;

namespace Diamonds.Tests {
  public class DiamondPaddingScenarios
  {
    private const char DiamondLetter = 'F';

    [Fact]
    public void letter_F_returns_paddingLeft_0()
    {
      var letter = 'F';
      var diamondPadding = new DiamondPadding(DiamondLetter);
      int paddingLeft = diamondPadding.GetLeft(letter);
      Assert.Equal(0, paddingLeft);
    }

    [Fact]
    public void letter_C_for_diamond_F_returns_paddingLeft_3()
    {
      var letter = 'C';
      var diamondPadding = new DiamondPadding(DiamondLetter);
      int paddingLeft = diamondPadding.GetLeft(letter);
      Assert.Equal(3, paddingLeft);
    }

    [Fact]
    public void letter_A_for_diamond_F_returns_paddingLeft_6()
    {
      var letter = 'A';
      var diamondPadding = new DiamondPadding(DiamondLetter);
      int paddingLeft = diamondPadding.GetLeft(letter);
      Assert.Equal(6, paddingLeft);
    }
  }

  public class DiamondPadding
  {
    private readonly AlphabeticalLetterConverter _alc;
    private readonly int _diamondLetterValue;

    public DiamondPadding(char diamondLetter)
    {
      _alc = new AlphabeticalLetterConverter();
      _diamondLetterValue = _alc.GetAlphabeticalValue(diamondLetter);
    }

    public int GetLeft(char letter)
    {
      var letterValue = _alc.GetAlphabeticalValue(letter);

      if (letter.Equals('A'))
      {
        return _diamondLetterValue;
      }

      return _diamondLetterValue - letterValue;
    }
  }
}
