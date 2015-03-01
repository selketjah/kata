﻿namespace Diamonds.Domain
{
  public class DiamondPadding
  {
    private readonly AlphabeticalLetterConverter _alc;
    private readonly int _diamondLetterValue;

    public DiamondPadding(char diamondLetter)
    {
      _alc = new AlphabeticalLetterConverter();
      _diamondLetterValue = _alc.GetAlphabeticalValue(diamondLetter);
    }

    public int GetLeft(char letter)
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