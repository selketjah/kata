namespace Kata.Calculator
{
	public class NumberSequence
	{
		private string _value;

		public NumberSequence(string value)
		{
			this._value = value;
		}

		public static implicit operator NumberSequence(string numbers)
		{
			return new NumberSequence(numbers);
		}

		public string GetDelimiter()
		{
			return _value.Substring(2, 1);
		}

		public bool HasPrefixedDelimiter()
		{
			return _value.StartsWith("//");
		}

		public NumberSequence Trim()
		{
			var delimiter = GetDelimiter();
			return _value.TrimStart('/').TrimStart(delimiter.ToCharArray());
		}

		public override string ToString()
		{
			return _value;
		}
	}
}