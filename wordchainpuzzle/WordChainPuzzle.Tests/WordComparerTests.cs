using NUnit.Framework;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Tests {
  [TestFixture]
  public class WordComparerTests {
    private OneLetterDifferentWordComparer _sut;

    [SetUp]
    public void Setup()
    {
      _sut = new OneLetterDifferentWordComparer("cat");
    }

    [Test]
    public void ReturnsTrueIfTwoWordsAreOneLetterApart() {
      var result = _sut.CompareWith("bat");
      Assert.IsTrue(result);
    }

    [Test]
    public void ReturnsFalseIfTwoWordsEqual() {
      var result = _sut.CompareWith("cat");
      Assert.IsFalse(result);
    }

    [Test]
    public void ReturnsFalseIfTwoWordsAreTwoOrMoreLettersApart() {
      var result = _sut.CompareWith("dfd");
      Assert.IsFalse(result);
    }

    [Test]
    public void ThrowsExceptionIfWordsHaveDifferentLength() {
      Assert.Throws<DifferentWordLengthException>(() => _sut.CompareWith("cats"));
    }
  }
}
