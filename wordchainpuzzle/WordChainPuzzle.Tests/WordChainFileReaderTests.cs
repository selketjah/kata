using System.Linq;
using NUnit.Framework;
using WordChainPuzzle.Domain;

namespace WordChainPuzzle.Tests {

  [TestFixture]
  public class WordChainFileReaderTests {
    [Test]
    public void LoadFileReturnsAnArrayOfStrings()
    {
      var fr = new WordChainFileReader();
      var dictionary = fr.CreateWordList(@"B:\PROJECTS\Kata\wordlist.txt");
      Assert.IsTrue(dictionary.Any());
    }

  }
}
