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

    public List<Word> RemoveDuplicates(List<Word> startList)
    {
      return startList.Where(w => !w.ToString().Equals(_cleanTo.ToString())).ToList();
    }

    public List<Word> RemoveWordsWithMoreThanOneDifferenceFromCleanWord(List<Word> startList)
    {
      return startList.Where(x => new OneLetterDifferentWordComparer(x.ToString()).CountDifferenceWith(_cleanTo.ToString()) <= 1).ToList();
    }

    public List<Word> RemoveWordsThatHaveAlreadyBeenSeen(List<Word> startList, List<Word> words)
    {
      return startList.Except(words).ToList();
    }

    public List<Word> SortByTargetWord(List<Word> wordlist, Word targetWord) {
      return wordlist.OrderBy(w => w.CountLetterDifferences(targetWord)).ToList();
    }
  }
}