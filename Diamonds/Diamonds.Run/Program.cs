using System;
using Diamonds.Domain;

namespace Diamonds.Run {
  class Program {
    static void Main(string[] args)
    {
      var diamond = new Diamond();
      var result = diamond.Make('F');
      Console.WriteLine(result);

      var result2 = diamond.Make('I');
      Console.WriteLine(result2);
      Console.Read();
    }
  }
}
