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
		public void EmptyNumberSequenceShouldReturnNul()
		{
			int result = calculator.Add(Model.EmptyNumberSequence);
			Assert.AreEqual(result, Model.EmptyNumberSequenceResult);
		}

		[Test]
		public void NumberSequenceWithOneNumberShouldReturnThatNumber()
		{
			int result = calculator.Add(Model.NumberSequenceWithOneNumber);
			Assert.AreEqual(result, Model.NumberSequenceWithOneNumberResult);
		}

		[Test]
		public void NumberSequenceWithTwoNumbersShouldReturnSumOfNumbers()
		{
			var result = calculator.Add(Model.NumberSequenceWithTwoNumbers);
			Assert.AreEqual(result, Model.NumberSequenceWithTwoNumbersResult);
		}

		[Test]
		public void NumberSequenceWithCommaDelimiterShouldReturnSumOfNumbers()
		{
			var actualResult = calculator.Add(Model.NumberSequenceWithCommaDelimiter);
			Assert.AreEqual(Model.NumberSequenceWithCommaDelimiterResult, actualResult);
		}

		[Test]
		public void StringWithLineDelimiterShouldReturnSumOfStrings()
		{
			var actualResult = calculator.Add(Model.NumberSequenceWithMultipleDelimiters);			
			Assert.AreEqual(actualResult, Model.NumberSequenceWithMultipleDelimitersResult);
		}
	}
}
