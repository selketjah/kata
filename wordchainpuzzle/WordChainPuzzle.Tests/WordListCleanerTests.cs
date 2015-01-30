using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Tests {
  [TestFixture]
  public class WordListCleanerTests {

    private WordListCleaner _sut;
    private List<Word> _startList;
    private Word cleanTo = new Word("cat");

    [SetUp]
    public void SetUp()
    {
      _startList = new List<Word>() { new Word("cat"), new Word("dog"), new Word("cot"), new Word("toolarge"), new Word("oa") };
      _sut = new WordListCleaner(cleanTo);
    }

    [Test]
    public void GivenACleanWordWhenCleaningListThenWordsWithDifferentLengthAreRemoved()
    {
      var result = _sut.RemoveWordsWithDifferentLength(_startList);
      Assert.That(result, Is.EquivalentTo(new List<Word>() { new Word("cat"), new Word("dog"), new Word("cot") }));
    }

    [Test]
    public void GivenACleanWordWhenRemovingDuplicatesThenDuplicateWordsAreRemoved()
    {
      var result = _sut.RemoveDuplicates(_startList);
      Assert.That(result, Is.EquivalentTo(new List<Word>() { new Word("dog"), new Word("cot"), new Word("toolarge"), new Word("oa") }));
    }

  }
}
