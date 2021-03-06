﻿using System;

namespace WordChainPuzzle.Domain
{
  public class Word
  {
    private readonly string _word;

    public Word(string word)
    {
      _word = word;
    }

    public int CountLetterDifferences(Word word)
    {
      if(_word.Length != word.GetLength()) throw new DifferentWordLengthException();

      var firstWordChars = _word.ToCharArray();
      var secondWordChars = word.ToCharArray();
      var result = 0;

      for (int i = 0; i < _word.Length; i++) {
        if (!firstWordChars[i].Equals(secondWordChars[i]))
          result++;
      }

      return result;
    }

    public Char[] ToCharArray()
    {
      return _word.ToCharArray();
    }

    public int GetLength()
    {
      return _word.Length;
    }

    public override string ToString()
    {
      return _word;
    }

    public override bool Equals(object obj)
    {
      var word = obj as Word;
      return word != null && _word.Equals(word.ToString());
    }

    public override int GetHashCode()
    {
      return _word.GetHashCode();
    }
  }
}