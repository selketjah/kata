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

      //var fibsum = new EvenFibonacciNumbers().GetSum(4000000);
      //Console.WriteLine(fibsum);

      var today = DateTime.Now;
      var firstDayNextMonth = new DateTime(DateTime.Now.Year, DateTime.Now.AddMonths(1).Month, 1);

      var dates = Enumerable.Range(0, firstDayNextMonth.Subtract(today).Days + 1).ToList();
      dates.ForEach(x => Console.WriteLine(x.ToString()));

      var temp = dates.Select(d => today.AddDays(d)).ToList();

      //var dates = new List<DateTime>();
      //for (var i = 0; i <= days; i++)
      //{
      //  dates.Add(today.AddDays(i));
      //}

      //dates.ForEach(x => Console.WriteLine(x.ToString()));
      Console.WriteLine("");

      Console.Read();

    }
  }
}
