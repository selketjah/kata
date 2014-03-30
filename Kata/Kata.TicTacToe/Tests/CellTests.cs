using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata.TicTacToe.Domain;
using NUnit.Framework;

namespace TicTacToe.Tests
{
	[TestFixture]
	public class CellTests
	{
		private Cell cell;
		[SetUp]
		public void Setup()
		{
			cell = new Cell();
		}

		[Test]
		public void EmptyCellShouldNotBeOccupied()
		{
			Assert.IsFalse(cell.Occupied);
		}

		[Test]
		public void CellWithSymbolShouldBeOccupied()
		{
			cell.SetValue(new Symbol());
			Assert.IsTrue(cell.Occupied);
		}

		[Test]
		public void CellWithSymbolShouldReturnSymbol()
		{
			var symbol = new Symbol();
			cell.SetValue(symbol);
			Assert.AreSame(cell.GetValue(), symbol);
		}

		[Test]
		public void CellShouldHaveColumn()
		{
			Assert.IsNotNull(cell.Column);
		}

		[Test]
		public void CellShouldHaveRow()
		{
			Assert.IsNotNull(cell.Row);
		}
}