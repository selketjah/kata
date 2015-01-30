using NUnit.Framework;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Tests {
  [TestFixture]
  public class WordListTests {
    private WordList _sut;

    //public void SetUp()
    //{
    //  //_sut = new WordList(new[] {"cat", "dog", "cot", "toolarge", "oa"}, new WordListCleaner("cat"));
    //}

    //[Test]
    //public void WordsWithDifferentLengthAreRemoved()
    //{
    //  var result = _sut.RemoveDifferentLengthWords();
    //  Assert.AreEqual(result, new[] { "cat", "dog", "cot" });
    //}

    //[Test]
    //public void DuplicatesAreRemoved()
    //{
    //  var result = _sut.RemoveDuplicates();
    //  Assert.AreEqual(result, new[] { "cat", "dog", "cot", "toolarge", "oa" });
    //}
  }
}