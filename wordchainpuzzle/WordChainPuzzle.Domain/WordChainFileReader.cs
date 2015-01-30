using System.Collections.Generic;
using System.IO;
using System;

namespace WordChainPuzzle.Domain
{
  public class WordChainFileReader
  {
    public List<Word> CreateWordList(string filePath)
    {
      using (var sr = new StreamReader(filePath))
      {
        var words = new List<Word>();
        var line = sr.ReadLine();
        while ((line = sr.ReadLine()) != null) {
          words.Add(new Word(line));
        }
        return words;
      }
    }
  }
}