namespace Diamonds.Domain
{
  public class OuterDiamondPaddingCalculator
  {
    private readonly AlphabeticalLetterConverter _alc;

    public OuterDiamondPaddingCalculator()
    {
      _alc = new AlphabeticalLetterConverter();
    }

    public int Get(char baseLetter, char letter)
    {
      var _diamondLetterValue = _alc.GetAlphabeticalValue(baseLetter);
      var letterValue = _alc.GetAlphabeticalValue(letter);

      if (letter.Equals('A'))
      {
        return _diamondLetterValue;
      }

      return _diamondLetterValue - letterValue;
    }
  }
}