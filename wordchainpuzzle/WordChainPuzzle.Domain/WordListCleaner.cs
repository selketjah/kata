namespace WordChainPuzzle.Domain
{
  public class WordListCleaner
  {
    private readonly string _word;

    public WordListCleaner(string word)
    {
      _word = word;
    }

    public int GetCleanLength()
    {
      return _word.Length;
    }
  }
}