using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Euler {
  class Program {
    static void Main(string[] args) {
      //var multiple = new MultiplesOfThreeAndFive();
      //var result = multiple.Sum(1000);
      //Console.WriteLine(result.ToString());

      var fibseq = string.Empty;
      var first = 1;
      var second = 1;
      fibseq = first + " " + second;

      var sum = 0;
      var exit = 4000000;

      do {
        var tempsum = first + second;

        if (tempsum % 2 == 0) sum += tempsum;

        fibseq = fibseq + " " + sum;
        first = second;
        second = tempsum;
      } while (exit >= second);

      Console.WriteLine(sum);
      Console.Read();

    }
  }
}
