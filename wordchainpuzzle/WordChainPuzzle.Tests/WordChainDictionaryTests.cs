using NUnit.Framework;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Tests {
  [TestFixture]
  public class WordChainDictionaryTests {
    private WordListCleaner _sut;

    public void SetUp()
    {
      _sut = new WordListCleaner(3, new[] {"cat", "dog", "cot", "toolarge", "oa"});
    }

    [Test]
    public void WordsWithDifferentLengthAreRemoved()
    {
      var result = _sut.RemoveDifferentLengthWords();
      Assert.AreEqual(result, new[] { "cat", "dog", "cot" });
    }

    [Test]
    public void DuplicatesAreRemoved()
    {
      var result = _sut.RemoveDuplicates();
      Assert.AreEqual(result, new[] { "cat", "dog", "cot", "toolarge", "oa" });
    }
  }
}