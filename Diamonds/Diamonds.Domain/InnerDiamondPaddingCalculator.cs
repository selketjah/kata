namespace Diamonds.Domain
{
  public class InnerDiamondPaddingCalculator
  {
    private readonly char _letter;
    private AlphabeticalLetterConverter _alc;

    public InnerDiamondPaddingCalculator(char letter)
    {
      _letter = letter;
      _alc = new AlphabeticalLetterConverter();
    }

    public int Get(char baseLetter)
    {
      if (_letter.Equals('A'))
      {
        return 0;
      }

      var baseDiamondLetterValue = GetBaseValue(baseLetter);
      var diamondLetterPositionValue = GetPositionValue(baseLetter, _letter);

      if (baseLetter.Equals(_letter))
      {
        return baseDiamondLetterValue;
      }

      return baseDiamondLetterValue - (diamondLetterPositionValue * 2);
    }

    private int GetPositionValue(char baseLetter, char letter)
    {
      var letterValue = _alc.GetAlphabeticalValue(letter);
      var diamondLetterPositionValue = _alc.GetAlphabeticalValue(baseLetter) - letterValue;
      return diamondLetterPositionValue;
    }

    private int GetBaseValue(char baseLetter)
    {
      var baseDiamondLetterValue = (_alc.GetAlphabeticalValue(baseLetter) * 2) - 1;
      return baseDiamondLetterValue;
    }
  }
}