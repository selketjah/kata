using System;
using System.Collections.Generic;
using System.Linq;

namespace Diamonds.Domain
{
  public class Diamond
  {
    public string Make(char baseLetter)
    {
      var rows = new List<string>();

      for (char c = baseLetter; c >= 'A'; c--)
      {
        var currentLetter = new DiamondLetter(c);

        var row = currentLetter.GetRow(baseLetter);

        if (c.Equals(baseLetter))
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
  }
}