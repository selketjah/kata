using System;
using System.Linq;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Play {
  class Program {
    static void Main(string[] args) {

      var fr = new WordChainFileReader();
      var dictionary = fr.LoadDictionary(@"wordlist.txt");
      var wordChainPuzzle = new WordChain(dictionary);

      Console.WriteLine("Enter begin and target word (e.g. cat - dog)");
      string words = Console.ReadLine();

      var wordArray = words.Split('-');
      if (dictionary.Contains(wordArray[0].Trim()) && dictionary.Contains(wordArray[1].Trim())) {
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
