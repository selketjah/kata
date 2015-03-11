﻿using System;

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

    public string GetRow(char diamondLetter) {

      var innerPadding = GetInnerPadding(diamondLetter);
      var outerPadding = GetOuterPadding(diamondLetter);
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
  }
}