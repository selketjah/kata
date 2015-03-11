using System;

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
      _innerDiamondPaddingCalculator = new InnerDiamondPaddingCalculator(_letter);
      _outerDiamondPaddingCalculator = new OuterDiamondPaddingCalculator(_letter);
    }

    public string GetRow(char diamondLetter) {

      var innerPadding = _innerDiamondPaddingCalculator.Get(diamondLetter);
      var outerPadding = _outerDiamondPaddingCalculator.Get(diamondLetter);
      if (innerPadding == 0) {
        return string.Format("{0}{1}{2}", GetPadding(outerPadding), _letter, GetPadding(outerPadding));
      }
      return string.Format("{0}{1}{2}{3}{4}", GetPadding(outerPadding), _letter, GetPadding(innerPadding), _letter, GetPadding(outerPadding));
    }

    private string GetPadding(int paddingNumber) {
      if (paddingNumber > 0) {
        return new String(' ', paddingNumber);
      }
      return "";
    }

    public override bool Equals(object obj)
    {
      var letter = obj is char ? (char) obj : '\0';
      return _letter.Equals(letter);
    }

    public override int GetHashCode()
    {
      return _letter.GetHashCode();
    }
  }
}