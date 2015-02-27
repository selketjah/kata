using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Euler {
  public class EvenFibonacciNumbers {
    public int GetSum(int max)
    {
      var fibseq = string.Empty;
      var first = 1;
      var second = 1;
      fibseq = first + " " + second;

      var sum = 0;
      var exit = max;

      do {
        var tempsum = first + second;

        if (tempsum % 2 == 0) sum += tempsum;

        fibseq = fibseq + " " + sum;
        first = second;
        second = tempsum;
      } while (exit >= second);

      return sum;
    }
  }
}
