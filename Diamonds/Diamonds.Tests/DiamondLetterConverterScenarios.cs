using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Diamonds.Tests {
  public class DiamondLetterConverterScenarios {

    [Fact]
    public void Given_the_capital_letter_f_it_returns_alphabetical_number_value()
    {
      var letter = 'F';
      var letterConverter = new AlphabeticalLetterConverter();
      var result = letterConverter.GetAlphabeticalValue(letter);
      Assert.Equal(6, result);
    }

    [Fact]
    public void Given_the_capital_letter_i_it_returns_alphabetical_number_value()
    {
      var letter = 'I';
      var letterConverter = new AlphabeticalLetterConverter();
      var result = letterConverter.GetAlphabeticalValue(letter);
      Assert.Equal(9, result);
    }

    [Fact]
    public void Given_the_lower_letter_i_it_returns_capital_alphabetical_number_value()
    {
      var letter = 'i';
      var letterConverter = new AlphabeticalLetterConverter();
      var result = letterConverter.GetAlphabeticalValue(letter);
      Assert.Equal(9, result);
    }
  }

  public class AlphabeticalLetterConverter
  {
    public int GetAlphabeticalValue(char letter)
    {
      return char.ToUpper(letter) - 64;
    }
  }
}
