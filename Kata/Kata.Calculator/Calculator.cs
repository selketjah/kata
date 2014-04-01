using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.Calculator
{
	public interface ICalculator
	{
		int Sum(NumberSequence numbers);
	}

	public class Calculator : ICalculator
	{
		internal int Sum(params string[] numbers)
		{
			IList<int> convertedNumbers = ConvertList(numbers);
			if (HasNegativeNumbers(convertedNumbers)) throw new Exception();
			return convertedNumbers.Sum();
		}

		internal bool HasNegativeNumbers(IEnumerable<int> numbers)
		{
			return numbers.Count(x => x < 0) > 0;
		}

		internal IList<int> ConvertList(params string[] numbers)
		{
			return numbers.Select(x => string.IsNullOrEmpty(x) ? 0 : Convert.ToInt32(x))
										.Where(n => n <= 1000)
										.ToList();
		}

		public int Sum(NumberSequence numbers)
		{
			var chars = new List<string>(){",", "\n"};
			if (numbers.HasPrefixedDelimiter())
			{
				chars.Add(numbers.GetDelimiter());
				numbers = numbers.Trim();
			}

			return Sum(numbers.ToString().Split(chars.ToArray(), StringSplitOptions.None));
		}
	}
}