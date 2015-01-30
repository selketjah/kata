using System.Collections.Generic;
using System.Linq;

namespace WordChainPuzzle.Domain
{

  public class WordListCleaner
  {
    private readonly Word _cleanTo;

    public WordListCleaner(Word cleanTo)
    {
      _cleanTo = cleanTo;
    }

    public List<Word> RemoveWordsWithDifferentLength(List<Word> wordList)
    {
      return wordList.Where(w => w.GetLength() == _cleanTo.GetLength()).ToList();
    }
  }
}