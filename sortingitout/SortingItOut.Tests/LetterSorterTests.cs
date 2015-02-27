using SortingItOut.Domain;
using Xunit;

namespace SortingItOut.Tests {
  public class LetterSorterTests {
    private string lower_case_sentence = "ww. 1te";
    private string letter_sentence = "wwte";
    private string alphabetical_sentence = "etww";
    private string sentence = "Ww. 1Te";

    private readonly LetterSorter _letterSorter;

    public LetterSorterTests() {
      _letterSorter = new LetterSorter();
    }

    [Fact]
    public void Given_a_sentence_it_makes_it_lower_case() {
      var result = _letterSorter.MakeLowerCase(sentence);
      Assert.Equal(lower_case_sentence, result);
    }

    [Fact]
    public void Given_a_sentence_it_removes_non_alphabetical()
    {
      var result = _letterSorter.RemoveNonAlphabeticalChars(sentence);
      Assert.Equal(letter_sentence, result);
    }

    [Fact]
    public void Given_a_sentence_it_sorts_alphabetical()
    {
      var result = _letterSorter.Sort(sentence);
      Assert.Equal(alphabetical_sentence, result);
    }
  }
}
