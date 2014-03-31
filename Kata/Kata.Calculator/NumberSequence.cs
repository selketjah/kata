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

		public override string ToString()
		{
			return _value;
		}
	}
}