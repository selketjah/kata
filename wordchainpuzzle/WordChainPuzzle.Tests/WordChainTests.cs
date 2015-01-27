using NUnit.Framework;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Tests
{
  [TestFixture]
  public class WordChainTests
  {
    [Test]
    public void RemoveWordsWithMoreThanOneDifferenceFromStartWord()
    {
      var dic = new[] { "fat", "dog", "cot" };
      var wordpuzzle = new WordChain(dic);
      var result = wordpuzzle.RemoveWordsWithMoreThanOneDifferenceFromStartWord(dic, "cat");
      Assert.AreEqual(result, new[] { "fat", "cot" });
    }

    [Test]
    public void ArrayIsSortedByTargetWord()
    {
      var dic = new[] {"fat", "dog", "cot"};
      var wordpuzzle = new WordChain(dic);
      var result = wordpuzzle.SortByTargetWord(dic, "cat");
      Assert.AreEqual(result, new[] { "fat", "cot", "dog" });
    }

    [Test]
    public void RemovesWordsThatHaveAlreadyBeenSeen()
    {
      var dic = new[] { "fat", "dog", "cot" };
      var wordpuzzle = new WordChain(dic);
      var result = wordpuzzle.RemoveWordsThatHaveAlreadyBeenSeen(dic, new[] {"cot"});
      Assert.AreEqual(result, new[] { "fat", "dog" });
    }

    [Test]
    public void SearchReturnsChainThreeWords() {
      var dic = new[] { "cat", "fat", "dog", "cot", "cog" };
      var wordpuzzle = new WordChain(dic);
      var result = wordpuzzle.GetChain("cat", "dog");
      Assert.AreEqual(result, "cat, cot, cog, dog");
    }

    [Test]
    public void SearchDogCatReturnsChainReversed()
    {
      var dic = new[] { "cat", "fat", "dog", "cot", "cog" };
      var wordpuzzle = new WordChain(dic);
      var result = wordpuzzle.GetChain("dog", "cat");
      Assert.AreEqual(result, "dog, cog, cot, cat");
    }

    [Test]
    public void SearchReturnsChainFourWords()
    {
      var dic = new[] { "lead", "ruby", "load", "rubs", "code", "rode", "goad", "gold" };
      var wordpuzzle = new WordChain(dic);
      var result = wordpuzzle.GetChain("lead", "gold");
      Assert.AreEqual(result, "lead, load, goad, gold");
    }
  }
}