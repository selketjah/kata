using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
