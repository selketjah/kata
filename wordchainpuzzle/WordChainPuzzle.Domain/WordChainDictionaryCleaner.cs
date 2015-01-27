using System;
using System.Linq;

namespace WordChainPuzzle.Domain
{
  public class WordChainDictionaryCleaner                                                                                                                                                   
  {
    private readonly int _wordLength;
    private string[] _dictionary;

    public WordChainDictionaryCleaner(int wordLength, string[] dictionary)
    {
      _wordLength = wordLength;
      _dictionary = dictionary;
    }

    public string[] Clean()
    {
      _dictionary = RemoveDifferentLengthWords();
      _dictionary = RemoveDuplicates();
      return _dictionary;
    }

    public string[] RemoveDifferentLengthWords()
    {
      return _dictionary.Where(w => w.Length == _wordLength).ToArray();
    }

    public string[] RemoveDuplicates()
    {
      return _dictionary.Distinct().ToArray();
    }
  }
}