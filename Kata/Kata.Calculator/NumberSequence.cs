namespace Kata.Calculator
{
	public struct NumberSequence
	{
		private string _value;

		private NumberSequence(string value)
		{
			this._value = value;
		}

		public static implicit operator NumberSequence(string numbers)
		{
			return new NumberSequence(numbers);
		}

		public string GetDelimiters()
		{
			return _value.Substring(2, 1);
		}

		public bool HasPrefixedDelimiter()
		{
			return _value.StartsWith("//");
		}

		public NumberSequence Trim()
		{
			var delimiter = GetDelimiters();
			return _value.TrimStart('/').TrimStart(delimiter.ToCharArray());
		}

		public override string ToString()
		{
			return _value;
		}
	}
}