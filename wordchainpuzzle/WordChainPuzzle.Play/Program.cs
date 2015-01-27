using System;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Play {
  class Program {
    static void Main(string[] args) {

      var fr = new WordChainFileReader();
      var dictionary = fr.LoadDictionary(@"wordlist.txt");
      var wordChainPuzzle = new WordChain(dictionary);

      Console.WriteLine("Enter begin and target word (e.g. cat - dog)");
      var words = Console.Read();


    }
  }
}
