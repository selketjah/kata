namespace Diamonds.Domain
{
  public class InnerDiamondPaddingCalculator
  {
    private readonly char _diamondLetter;
    private AlphabeticalLetterConverter _alc;
    private readonly int _diamondLetterValue;

    public InnerDiamondPaddingCalculator(char diamondLetter)
    {
      _diamondLetter = diamondLetter;
      _alc = new AlphabeticalLetterConverter();
      _diamondLetterValue = _alc.GetAlphabeticalValue(diamondLetter);
    }

    public int Get(char letter)
    {
      if (letter.Equals('A'))
      {
        return 0;
      }

      var baseDiamondLetterValue = GetBaseValue();
      var diamondLetterPositionValue = GetPositionValue(letter);

      if (_diamondLetter.Equals(letter))
      {
        return baseDiamondLetterValue;
      }

      return baseDiamondLetterValue - (diamondLetterPositionValue * 2);
    }

    private int GetPositionValue(char letter)
    {
      var letterValue = _alc.GetAlphabeticalValue(letter);
      var diamondLetterPositionValue = _diamondLetterValue - letterValue;
      return diamondLetterPositionValue;
    }

    private int GetBaseValue()
    {
      var baseDiamondLetterValue = (_diamondLetterValue * 2) - 1;
      return baseDiamondLetterValue;
    }
  }
}