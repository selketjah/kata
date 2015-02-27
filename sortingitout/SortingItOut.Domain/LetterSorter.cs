using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingItOut.Domain
{
  public class LetterSorter {

    public string MakeLowerCase(string sentence) {
      return sentence.ToLower();
    }

    public string RemoveNonAlphabeticalChars(string sentence)
    {
      sentence = MakeLowerCase(sentence);
      var chararray = sentence.ToCharArray();
      var result = new List<char>();

      foreach (var character in chararray) {
        if (char.IsLetter(character)) {
          result.Add(character);
        }
      }

      return new string(result.ToArray());
    }

    public string Sort(string sentence)
    {
      sentence = MakeLowerCase(sentence);
      sentence = RemoveNonAlphabeticalChars(sentence);

      var chararray = sentence.ToCharArray();
      Array.Sort(chararray);
      return new string(chararray.ToArray());
    }
  }
}