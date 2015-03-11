namespace Diamonds.Domain
{
  public class DiamondLetter
  {
    private readonly char _letter;
    private readonly InnerDiamondPaddingCalculator _innerDiamondPaddingCalculator;
    private readonly OuterDiamondPaddingCalculator _outerDiamondPaddingCalculator;

    public DiamondLetter(char letter)
    {
      _letter = letter;
      _innerDiamondPaddingCalculator = new InnerDiamondPaddingCalculator();
      _outerDiamondPaddingCalculator = new OuterDiamondPaddingCalculator();
    }

    public int GetInnerPadding(char diamondLetter)
    {
      return _innerDiamondPaddingCalculator.Get(diamondLetter, _letter);
    }

    public int GetOuterPadding(char diamondLetter)
    {
      return _outerDiamondPaddingCalculator.Get(diamondLetter, _letter);
    }
  }
}