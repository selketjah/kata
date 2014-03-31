using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata.Calculator
{
	[TestFixture]
	public class CalculatorTests
	{
		private ICalculator calculator;

		[SetUp]
		public void Setup()
		{
			calculator = new Calculator();
		}

		[Test]
		public void EmptyStringShouldReturnNul()
		{
			var empty = string.Empty;
			int result = calculator.Add(empty);
			Assert.AreEqual(result, 0);
		}

		[Test]
		public void OneStringShouldReturnStringAsNumber()
		{
			NumberSequence one = "1";
			const int expectedResult = 1;
			int result = calculator.Add(one);
			Assert.AreEqual(result, expectedResult);
		}

		[Test]
		public void TwoStringsShouldReturnSumOfStrings()
		{
			NumberSequence numbers = "4,3";
			const int expectedResult = 7;
			var result = calculator.Add(numbers);
			Assert.AreEqual(expectedResult, result);
		}

		[Test]
		public void FourStringsShouldReturnSumOfStrings()
		{
			NumberSequence numbers = "0,1,2,3";
			const int expectedResult = 6;
			var actualResult = calculator.Add(numbers);

			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void FourNumbersAsStringShouldReturnSumOfStrings()
		{
			NumberSequence numbers = "0,1,2,3";
			const int expectedResult = 6;
			var actualResult = calculator.Add(numbers);

			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void StringWithLineDelimiterShouldReturnSumOfStrings()
		{
			NumberSequence numbers = "0,1\n2,3";
			const int expectedResult = 6;
			var actualResult = calculator.Add(numbers);
			
			Assert.AreEqual(actualResult, expectedResult);
		}
	}
}
