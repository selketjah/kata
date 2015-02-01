using System.Collections.Generic;
using NUnit.Framework;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Tests {
  [TestFixture]
  public class WordChainTests {
    private List<Word> _words;
    private List<Word> _fourLetterWords;
      
    [SetUp]
    public void Setup() {
      _words = new List<Word>() { new Word("cat"), new Word("fat"), new Word("dog"), new Word("cot"), new Word("cog") };
      _fourLetterWords = new List<Word>() { new Word("lead"), new Word("ruby"), new Word("load"), new Word("rubs"), new Word("code"), new Word("rode"), new Word("goad"), new Word("gold") };
    }

    [Test]
    public void SearchReturnsChainThreeWords() {
      var wordpuzzle = new WordChain(_words);
      var result = wordpuzzle.GetChain("cat", "dog");
      Assert.AreEqual(result, "cat, cot, cog, dog");
    }

    [Test]
    public void SearchDogCatReturnsChainReversed() {
      var wordpuzzle = new WordChain(_words);
      var result = wordpuzzle.GetChain("dog", "cat");
      Assert.AreEqual(result, "dog, cog, cot, cat");
    }

    [Test]
    public void SearchReturnsChainFourWords() {
      var wordpuzzle = new WordChain(_fourLetterWords);
      var result = wordpuzzle.GetChain("lead", "gold");
      Assert.AreEqual(result, "lead, load, goad, gold");
    }

    [Test]
    public void SearchReturnsChainFourWordsReversed() {
      var wordpuzzle = new WordChain(_fourLetterWords);
      var result = wordpuzzle.GetChain("gold", "lead");
      Assert.AreEqual(result, "gold, goad, load, lead");
    }
  }
}