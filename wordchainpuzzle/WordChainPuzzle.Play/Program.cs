﻿using System;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Play {
  class Program {
    static void Main(string[] args) {

      var fr = new WordChainFileReader();
      var dictionary = fr.CreateWordList(@"wordlist.txt");
      var wordChainPuzzle = new WordChain(dictionary);

      Console.WriteLine("Enter begin and target word (e.g. cat - dog)");
      string words = Console.ReadLine();

      var wordArray = words.Split('-');
      if (dictionary.Contains(new Word(wordArray[0].Trim())) && dictionary.Contains(new Word(wordArray[1].Trim()))) {
        var chain = wordChainPuzzle.GetChain(wordArray[0].Trim(), wordArray[1].Trim());
        Console.WriteLine("Word chain");
        Console.WriteLine(chain);
      }
      else {
        Console.WriteLine("Words not in dictionary");
      }

      Console.ReadLine();

    }
  }
}
