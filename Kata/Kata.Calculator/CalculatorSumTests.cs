using System;
using NUnit.Framework;

namespace Kata.Calculator
{
	[TestFixture]
	public class CalculatorSumTests
	{
		private ICalculator _calculator;

		[SetUp]
		public void Setup()
		{
			_calculator = new Calculator();
		}

		[Test]
		public void EmptyNumberSequenceShouldReturnNul()
		{
			int result = _calculator.Sum(Model.EmptyNumberSequence);
			Assert.AreEqual(result, Model.EmptyNumberSequenceResult);
		}

		[Test]
		public void NumberSequenceWithOneNumberShouldReturnThatNumber()
		{
			int result = _calculator.Sum(Model.NumberSequenceWithOneNumber);
			Assert.AreEqual(result, Model.NumberSequenceWithOneNumberResult);
		}

		[Test]
		public void NumberSequenceWithTwoNumbersShouldReturnSumOfNumbers()
		{
			var result = _calculator.Sum(Model.NumberSequenceWithTwoNumbers);
			Assert.AreEqual(result, Model.NumberSequenceWithTwoNumbersResult);
		}

		[Test]
		public void NumberSequenceWithCommaDelimiterShouldReturnSumOfNumbers()
		{
			var actualResult = _calculator.Sum(Model.NumberSequenceWithCommaDelimiter);
			Assert.AreEqual(Model.NumberSequenceWithCommaDelimiterResult, actualResult);
		}

		[Test]
		public void NumberSequenceWithMultipleDelimitersShouldReturnSumOfNumbers()
		{
			var actualResult = _calculator.Sum(Model.NumberSequenceWithMultipleDelimiters);			
			Assert.AreEqual(actualResult, Model.NumberSequenceWithMultipleDelimitersResult);
		}

		[Test]
		public void NumberSequenceWithPrefixDelimiterShouldReturnSumOfNumbers()
		{
			var result = _calculator.Sum(Model.NumberSequenceWithPrefixedDelimiters);
			Assert.AreEqual(result, Model.NumberSequenceWithPrefixedDelimitersResult);
		}

		[Test]
		public void NumberSequenceWithNegativeNumbersThrowsException()
		{
			TestDelegate act = () => _calculator.Sum(Model.NumberSequenceWithNegativeNumbers);
			Assert.Throws<Exception>(act);
		}

		[Test]
		public void NumbersBiggerThanThousandShouldBeIgnored()
		{
			var result = _calculator.Sum(Model.NumberSequenceWithNumberBiggerThanThousand);
			Assert.AreEqual(result, Model.NumberSequenceWithNumberBiggerThanThousandResult);
		}
	}
}
