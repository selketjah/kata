using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diamonds.Domain;
using Xunit;

namespace Diamonds.Tests {
  public class MiddleDiamondPaddingScenarios {
    private const char DiamondLetter = 'F';

    [Fact]
    public void char_F_returns_middlePadding_11()
    {
      var letter = 'F';
      var middleDiamondPadding = new MiddleDiamondPadding(DiamondLetter);
      var result = middleDiamondPadding.Get(letter);
      Assert.Equal(11, result);
    }

    [Fact]
    public void char_C_returns_middlePadding_5()
    {
      var letter = 'C';
      var middleDiamondPadding = new MiddleDiamondPadding(DiamondLetter);
      var result = middleDiamondPadding.Get(letter);
      Assert.Equal(5, result);
    }
  }

  public class MiddleDiamondPadding
  {
    private readonly char _diamondLetter;
    private AlphabeticalLetterConverter _alc;

    public MiddleDiamondPadding(char diamondLetter)
    {
      _diamondLetter = diamondLetter;
      _alc = new AlphabeticalLetterConverter();
    }

    public int Get(char letter)
    {
      var baseValue = 11;

      if (_diamondLetter.Equals(letter))
      {
        return baseValue;
      }

      var diamondLetterValue = _alc.GetAlphabeticalValue(_diamondLetter);
      var letterValue = _alc.GetAlphabeticalValue(letter);

      var diamondLetterPositionValue = diamondLetterValue - letterValue;

      return (diamondLetterValue * 2) - (diamondLetterPositionValue * 2) - 1;
    }
  }
}
