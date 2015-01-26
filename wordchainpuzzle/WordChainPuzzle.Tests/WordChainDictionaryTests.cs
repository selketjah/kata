using NUnit.Framework;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Tests {
  [TestFixture]
  public class WordChainDictionaryTests {

    [Test]
    public void WordsWithDifferentLengthAreRemoved()
    {
      var wordpuzzle = new WordChainDictionary("cat", 3, new []{"cat", "dog", "cot", "toolarge", "oa"});
      var result = wordpuzzle.RemoveDifferentLengthWords();
      Assert.AreEqual(result, new[] { "cat", "dog", "cot" });
    }

    [Test]
    public void DuplicatesAreRemoved()
    {
      var wordpuzzle = new WordChainDictionary("cat", 3, new[] { "cat", "dog", "cot", "cat", "toolarge", "oa" });
      var result = wordpuzzle.RemoveDuplicates();
      Assert.AreEqual(result, new[] { "cat", "dog", "cot", "toolarge", "oa" });
    }

    [Test]
    public void ArrayIsSortedByTargetWord()
    {
      var wordpuzzle = new WordChainDictionary("cat", 3, new[] { "fat", "dog", "cot" });
      var result = wordpuzzle.SortByTargetWord();
      Assert.AreEqual(result, new[] { "fat", "cot", "dog" });

    }
  }
}