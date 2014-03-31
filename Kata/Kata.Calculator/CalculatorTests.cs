using System;
using NUnit.Framework;

namespace Kata.Calculator
{
	[TestFixture]
	public class CalculatorTests
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
			int result = _calculator.Add(Model.EmptyNumberSequence);
			Assert.AreEqual(result, Model.EmptyNumberSequenceResult);
		}

		[Test]
		public void NumberSequenceWithOneNumberShouldReturnThatNumber()
		{
			int result = _calculator.Add(Model.NumberSequenceWithOneNumber);
			Assert.AreEqual(result, Model.NumberSequenceWithOneNumberResult);
		}

		[Test]
		public void NumberSequenceWithTwoNumbersShouldReturnSumOfNumbers()
		{
			var result = _calculator.Add(Model.NumberSequenceWithTwoNumbers);
			Assert.AreEqual(result, Model.NumberSequenceWithTwoNumbersResult);
		}

		[Test]
		public void NumberSequenceWithCommaDelimiterShouldReturnSumOfNumbers()
		{
			var actualResult = _calculator.Add(Model.NumberSequenceWithCommaDelimiter);
			Assert.AreEqual(Model.NumberSequenceWithCommaDelimiterResult, actualResult);
		}

		[Test]
		public void NumberSequenceWithMultipleDelimitersShouldReturnSumOfNumbers()
		{
			var actualResult = _calculator.Add(Model.NumberSequenceWithMultipleDelimiters);			
			Assert.AreEqual(actualResult, Model.NumberSequenceWithMultipleDelimitersResult);
		}

		[Test]
		public void NumberSequenceWithPrefixDelimiterShouldReturnSumOfNumbers()
		{
			var result = _calculator.Add(Model.NumberSequenceWithPrefixedDelimiters);
			Assert.AreEqual(result, Model.NumberSequenceWithPrefixedDelimitersResult);
		}

		[Test]
		public void NumberSequenceWithNegativeNumbersThrowsException()
		{
			TestDelegate act = () => _calculator.Add(Model.NumberSequenceWithNegativeNumbers);
			Assert.Throws<Exception>(act);
		}
	}
}
