using System.Globalization;
using System.Linq;

namespace Kata.Calculator
{
	public static class Model
	{
		private static readonly int zero = 0;
		private static readonly int one = 1;
		private static readonly int two = 2;
		private static readonly int three = 3;

		public static readonly NumberSequence EmptyNumberSequence = string.Empty;
		public static readonly NumberSequence NumberSequenceWithOneNumber = one.ToString(CultureInfo.InvariantCulture);
		public static readonly NumberSequence NumberSequenceWithTwoNumbers = string.Join(",", one, two);
		public static readonly NumberSequence NumberSequenceWithCommaDelimiter = string.Join(",", zero, one, two, three);
		public static readonly NumberSequence NumberSequenceWithMultipleDelimiters = string.Format("{0},{1}\n{2},{3}", zero, one, two, three);

		public static readonly int EmptyNumberSequenceResult = 0;
		public static readonly int NumberSequenceWithOneNumberResult = 1;
		public static readonly int NumberSequenceWithTwoNumbersResult = one + two;
		public static readonly int NumberSequenceWithCommaDelimiterResult = zero + one + two + three;
		public static readonly int NumberSequenceWithMultipleDelimitersResult = zero + one + two + three;
	}
}