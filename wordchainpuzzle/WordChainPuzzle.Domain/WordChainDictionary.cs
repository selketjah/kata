using System;
using System.Linq;

namespace WordChainPuzzle.Domain
{
  public class WordChainDictionary                                                                                                                                                   
  {
    private readonly string _targetWord;
    private readonly int _wordLength;
    private string[] _dictionary;

    public WordChainDictionary(string targetWord, int wordLength, string[] dictionary)
    {
      _targetWord = targetWord;
      _wordLength = wordLength;
      _dictionary = dictionary;
    }

    public string[] Clean()
    {
      _dictionary = RemoveDifferentLengthWords();
      _dictionary = RemoveDuplicates();
      _dictionary = SortByTargetWord();
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

    public string[] SortByTargetWord()
    {
      var temp = _dictionary.OrderBy(w => new OneLetterDifferentWordComparer(w, _targetWord).CountDifference()).ToArray();
      return temp;
    }
  }
}