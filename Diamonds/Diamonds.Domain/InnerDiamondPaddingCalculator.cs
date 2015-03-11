namespace Diamonds.Domain
{
  public class InnerDiamondPaddingCalculator
  {
    private AlphabeticalLetterConverter _alc;

    public InnerDiamondPaddingCalculator()
    {
      _alc = new AlphabeticalLetterConverter();
    }

    public int Get(char baseLetter, char letter)
    {
      if (letter.Equals('A'))
      {
        return 0;
      }

      var baseDiamondLetterValue = GetBaseValue(baseLetter);
      var diamondLetterPositionValue = GetPositionValue(baseLetter, letter);

      if (baseLetter.Equals(letter))
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