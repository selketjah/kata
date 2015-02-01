using System;
using System.Collections.Generic;
using System.Linq;

namespace WordChainPuzzle.Domain {
  public class WordChain {
    private readonly List<Word> _dictionary;

    public WordChain(List<Word> dictionary) {
      _dictionary = dictionary;
    }

    public string GetChain(string startWord, string targetWord) {
      if (startWord == null) throw new ArgumentNullException("startWord");
      if (targetWord == null) throw new ArgumentNullException("targetWord");

      var cleaner = new WordListCleaner(new Word(startWord));
      var wordlist = cleaner.RemoveWordsWithDifferentLength(_dictionary);
      wordlist = cleaner.RemoveDuplicates(wordlist);

      var chainList = new List<Word>();
      Search(new Word(startWord), new Word(targetWord), chainList, wordlist);
      return String.Join(", ", chainList);
    }

    public bool Search(Word startWord, Word targetWord, List<Word> chain, List<Word> dictionary)
    {
      var listCleaner = new WordListCleaner(startWord);
      var wordlist = listCleaner.RemoveWordsWithMoreThanOneDifferenceFromCleanWord(dictionary);
      wordlist = listCleaner.RemoveWordsThatHaveAlreadyBeenSeen(wordlist, chain);
      wordlist = listCleaner.SortByTargetWord(wordlist, targetWord);

      for (int i = 0; i < wordlist.Count; i++)
      {
        var word = wordlist[i];
        chain.Add(startWord);
        if (word.Equals(targetWord))
        {
          chain.Add(targetWord);
          return true;
        }

        var success = Search(word, targetWord, chain, dictionary);
        if (success)
        {
          return true;
        }
        chain.Remove(chain.Last());
      }

      return false;
    }
  }
}