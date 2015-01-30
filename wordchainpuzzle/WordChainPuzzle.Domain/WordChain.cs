using System;
using System.Collections.Generic;
using System.Linq;

namespace WordChainPuzzle.Domain {
  public class WordChain {
    private readonly string[] _dictionary;

    public WordChain(string[] dictionary) {
      _dictionary = dictionary;
    }

    public string GetChain(string beginWord, string targetWord) {
      if (beginWord == null) throw new ArgumentNullException("beginWord");
      if (targetWord == null) throw new ArgumentNullException("targetWord");
      //prep dictionary
      var dictionaryCleaner = new WordListCleaner(beginWord.Length, _dictionary);
      var wordlist = dictionaryCleaner.Clean();
      //get chain
      var chainList = new List<string>();
      var chain = Search(beginWord, targetWord, chainList, wordlist);
      return String.Join(", ", chainList);
    }

    public bool Search(string startWord, string targetWord, List<string> chain, string[] dictionary) {
      var wordlist = this.RemoveWordsWithMoreThanOneDifferenceFromStartWord(dictionary, startWord);
      wordlist = this.RemoveWordsThatHaveAlreadyBeenSeen(wordlist, chain.ToArray());
      wordlist = this.SortByTargetWord(wordlist, targetWord);

      for (int i = 0; i < wordlist.Length; i++)
      {
        string word = wordlist[i];
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

    public string[] SortByTargetWord(string[] wordlist, string targetWord) {
      return wordlist.OrderBy(w => new OneLetterDifferentWordComparer(w).CountDifferenceWith(targetWord)).ToArray();
    }

    public string[] RemoveWordsThatHaveAlreadyBeenSeen(string[] wordlist, string[] chain) {
      return wordlist.Except(chain).ToArray();
    }

    public string[] RemoveWordsWithMoreThanOneDifferenceFromStartWord(string[] wordlist, string startWord)
    {
      return wordlist.Where(x => new OneLetterDifferentWordComparer(x).CountDifferenceWith(startWord) <= 1).ToArray();
    }
  }
}