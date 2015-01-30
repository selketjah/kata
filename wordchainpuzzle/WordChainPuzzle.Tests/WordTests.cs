using NUnit.Framework;

namespace WordChainPuzzle.Tests {
  [TestFixture]
  public class WordTests {

    [Test]
    public void GivenAWordWhenComparingToOtherWordThenItReturnsNumberOfDifferences()
    {
      var word = new Word("cat");
      var result = word.CompareTo("dog");
    }

  }

  public class Word
  {
    private readonly string _word;

    public Word(string word)
    {
      _word = word;
    }

    public bool CompareTo(string dog)
    {
      throw new System.NotImplementedException();
    }
  }
}
