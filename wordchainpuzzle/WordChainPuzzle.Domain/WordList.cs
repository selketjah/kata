using System.Linq;

namespace WordChainPuzzle.Domain
{
  public class WordList                                                                                                                                                   
  {
    private string[] _dictionary;
    private readonly WordListCleaner _cleaner;

    public WordList(string[] dictionary, WordListCleaner cleaner)
    {
      _dictionary = dictionary;
      _cleaner = cleaner;
    }

    public string[] Clean()
    {
      _dictionary = RemoveDifferentLengthWords();
      _dictionary = RemoveDuplicates();
      return _dictionary;
    }

    public string[] RemoveDifferentLengthWords()
    {
      return _dictionary.Where(w => w.Length == _cleaner.GetCleanLength()).ToArray();
    }

    public string[] RemoveDuplicates()
    {
      return _dictionary.Distinct().ToArray();
    }
  }
}