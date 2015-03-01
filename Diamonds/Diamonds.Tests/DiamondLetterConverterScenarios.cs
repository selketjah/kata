using Diamonds.Domain;
using Xunit;

namespace Diamonds.Tests {
  public class DiamondLetterConverterScenarios {
    private AlphabeticalLetterConverter _alphabeticalLetterConverter;

    public DiamondLetterConverterScenarios()
    {
      _alphabeticalLetterConverter = new AlphabeticalLetterConverter();
    }

    [Fact]
    public void Given_the_capital_letter_f_it_returns_alphabetical_number_value()
    {
      var letter = 'F';
      var result = _alphabeticalLetterConverter.GetAlphabeticalValue(letter);
      Assert.Equal(6, result);
    }

    [Fact]
    public void Given_the_capital_letter_i_it_returns_alphabetical_number_value()
    {
      var letter = 'I';
      var result = _alphabeticalLetterConverter.GetAlphabeticalValue(letter);
      Assert.Equal(9, result);
    }

    [Fact]
    public void Given_the_lower_letter_i_it_returns_capital_alphabetical_number_value()
    {
      var letter = 'i';
      var result = _alphabeticalLetterConverter.GetAlphabeticalValue(letter);
      Assert.Equal(9, result);
    }
  }
}
