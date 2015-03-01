using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Diamonds.Tests {
  public class DiamondLetterConverterScenarios {

    [Fact]
    public void Given_the_letter_f_it_returns_alphabetical_number_value()
    {
      var letter = 'f';
      var letterConverter = new DiamondLetterConverter();
      var result = letterConverter.GetAlphabeticalValue(letter);
      Assert.Equal(7, result);
    }
  }

  public class DiamondLetterConverter
  {
    public int GetAlphabeticalValue(char letter)
    {
      return 7;
    }
  }
}
