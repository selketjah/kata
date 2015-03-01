using System;
using Diamonds.Domain;

namespace Diamonds.Run {
  class Program {
    static void Main(string[] args)
    {
      var diamond = new Diamond();
      var result = diamond.Make('F');
      Console.WriteLine(result);
      Console.Read();
    }
  }
}
