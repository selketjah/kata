namespace Diamonds.Domain
{
  public class LeftDiamondPadding
  {
    private readonly AlphabeticalLetterConverter _alc;
    private readonly int _diamondLetterValue;

    public LeftDiamondPadding(char diamondLetter)
    {
      _alc = new AlphabeticalLetterConverter();
      _diamondLetterValue = _alc.GetAlphabeticalValue(diamondLetter);
    }

    public int Get(char letter)
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