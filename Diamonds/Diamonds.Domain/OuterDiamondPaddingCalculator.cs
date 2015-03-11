namespace Diamonds.Domain
{
  public class OuterDiamondPaddingCalculator
  {
    private readonly char _letter;
    private readonly AlphabeticalLetterConverter _alc;

    public OuterDiamondPaddingCalculator(char letter)
    {
      _letter = letter;
      _alc = new AlphabeticalLetterConverter();
    }

    public int Get(char baseLetter)
    {
      var _diamondLetterValue = _alc.GetAlphabeticalValue(baseLetter);
      var letterValue = _alc.GetAlphabeticalValue(_letter);

      if (_letter.Equals('A'))
      {
        return _diamondLetterValue;
      }

      return _diamondLetterValue - letterValue;
    }
  }
}