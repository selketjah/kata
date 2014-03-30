namespace Kata.TicTacToe.Domain
{
	public class Cell
	{
		public Cell()
		{
			this.Column = 0;
			this.Row = 0;
		}

		public bool Occupied { get; set; }
		public Symbol Symbol { get; set; }

		public int? Column { get; set; }

		public int? Row { get; set; }

		public void SetValue(Symbol symbol)
		{
			this.Symbol = symbol;
			this.Occupied = true;
		}

		public Symbol GetValue()
		{
			return this.Symbol;
		}
	}
}