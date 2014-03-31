using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata.Calculator
{
	public interface ICalculator
	{
		int Add(NumberSequence numbers);
	}

	public class Calculator : ICalculator
	{
		internal int Add(params string[] numbers)
		{
			IList<int> convertedNumbers = ConvertToIntegers(numbers);
			if (HasNegativeNumbers(convertedNumbers)) throw new Exception();
			return convertedNumbers.Sum();
		}

		internal bool HasNegativeNumbers(IEnumerable<int> numbers)
		{
			return numbers.Count(x => x < 0) > 0;
		}

		internal IList<int> ConvertToIntegers(params string[] numbers)
		{
			return numbers.Select(x => string.IsNullOrEmpty(x) ? 0 : Convert.ToInt32(x)).ToList();
		}

		public int Add(NumberSequence numbers)
		{
			var chars = new List<string>(){",", "\n"};
			if (HasPrefixedDelimiter(numbers))
			{
				var delimiter = numbers.ToString().Substring(2, 1);
				chars.Add(delimiter);
				numbers = numbers.ToString().TrimStart('/').TrimStart(delimiter.ToCharArray());
			}

			return Add(numbers.ToString().Split(chars.ToArray(), StringSplitOptions.None));
		}

		internal bool HasPrefixedDelimiter(NumberSequence numbers)
		{
			return numbers.ToString().StartsWith("//");
		}
	}
}