using NUnit.Framework;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Tests {
  [TestFixture]
  public class WordComparerTests {
    private OneLetterDifferentWordComparer _sut;

    [Test]
    public void ReturnsTrueIfTwoWordsAreOneLetterApart() {
      _sut = new OneLetterDifferentWordComparer("cat", "bat");
      var result = _sut.Compare();
      Assert.IsTrue(result);
    }

    [Test]
    public void ReturnsFalseIfTwoWordsEqual() {
      _sut = new OneLetterDifferentWordComparer("cat", "cat");
      var result = _sut.Compare();
      Assert.IsFalse(result);
    }

    [Test]
    public void ReturnsFalseIfTwoWordsAreTwoOrMoreLettersApart() {
      _sut = new OneLetterDifferentWordComparer("cat", "dfd");
      var result = _sut.Compare();
      Assert.IsFalse(result);
    }

    [Test]
    public void ThrowsExceptionIfWordsHaveDifferentLength() {
      _sut = new OneLetterDifferentWordComparer("cat", "cats");
      Assert.Throws<DifferentWordLengthException>(() => _sut.Compare());
    }
  }
}
