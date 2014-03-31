using System;
using System.Linq;

namespace Kata.Calculator
{
	public interface ICalculator
	{
		int Add(NumberSequence numbers);
	}

	public class Calculator : ICalculator
	{
		public int Add(params string[] numbers)
		{
			return numbers.Select(x => string.IsNullOrEmpty(x) ? 0 : Convert.ToInt32(x))
			              .Sum();
		}

		public int Add(NumberSequence numbers)
		{
			return Add(numbers.ToString().Split(new char[2] {',', '\n'}, StringSplitOptions.None));
		}
	}
}