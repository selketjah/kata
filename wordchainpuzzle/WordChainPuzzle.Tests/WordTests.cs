using NUnit.Framework;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Tests {
  [TestFixture]
  public class WordTests {
    private Word dog = new Word("dog");
    private string keyword = "cat";
    private Word _sut;

    [SetUp]
    public void SetUp()
    {
      _sut = new Word(keyword);
    }

    [Test]
    public void GivenAWordWhenGettingLengthThenItReturnsLength()
    {
      var word = new Word(keyword);
      var result = word.GetLength();
      Assert.AreEqual(result, keyword.Length);
    }

    [Test]
    public void GivenAThreeLengthWordWhenCountingDifferenceToFourLengthWordThenItThrowsException()
    {
      Assert.Throws<DifferentWordLengthException>(() => _sut.CountLetterDifferences(new Word("cats")));
    }

    [Test]
    public void GivenAWordCatWhenCountingDifferencesToOtherWordWithNoLettersEqualThenItReturnsThree() {
      var word = new Word(keyword);
      var result = word.CountLetterDifferences(dog);
      Assert.AreEqual(result, word.GetLength());
    }

  }
}
