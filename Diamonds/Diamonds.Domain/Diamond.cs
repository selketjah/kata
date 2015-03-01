using System;
using System.Collections.Generic;
using System.Linq;

namespace Diamonds.Domain
{
  public class Diamond
  {
    public string Make(char letter)
    {
      var leftDiamondPadding = new OuterDiamondPaddingCalculator(letter);
      var middleDiamondPadding = new InnerDiamondPaddingCalculator(letter);

      var rows = new List<string>();

      for (char c = letter; c >= 'A'; c--)
      {

        var paddingLeft = leftDiamondPadding.Get(c);
        var paddingMiddle = middleDiamondPadding.Get(c);
        var row = GetRow(c, paddingLeft, paddingMiddle);

        if (c.Equals(letter))
        {
          rows.Add(row);
        }
        else
        {
          rows.Insert(0, row);
          rows.Add(row);
        }
      }

      return rows.Aggregate((current, row) => string.Format(@"{0}{1}{2}", current, Environment.NewLine, row));
    }

    private string GetRow(char c, int outerPaddingNumber, int innerPaddingNumber)
    {
      var innerPadding = GetPadding(innerPaddingNumber);
      var outerPadding = GetPadding(outerPaddingNumber);
      if (innerPaddingNumber == 0)
      {
        return string.Format("{0}{1}{2}", outerPadding, c, outerPadding);
      }
      return string.Format("{0}{1}{2}{3}{4}", outerPadding, c, innerPadding, c, outerPadding);
    }

    private string GetPadding(int paddingNumber)
    {
      if (paddingNumber > 0)
      {
        return new String(' ', paddingNumber);
      }
      return "";
    }
  }
}