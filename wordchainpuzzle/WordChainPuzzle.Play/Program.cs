using System;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Play {
  class Program {
    static void Main(string[] args) {

      Console.WriteLine("Enter begin and target word (e.g. cat dog)");
      var words = Console.Read();

      var fr = new WordChainFileReader();
      var dictionary = fr.LoadDictionary(@"B:\PROJECTS\Kata\wordlist.txt");
      

    }
  }
}
