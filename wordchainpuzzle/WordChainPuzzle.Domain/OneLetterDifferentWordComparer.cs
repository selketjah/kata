namespace WordChainPuzzle.Domain
{
  public class OneLetterDifferentWordComparer {
    private readonly string _keyWord;

    public OneLetterDifferentWordComparer(string keyWord)
    {
      _keyWord = keyWord;
    }

    public bool CompareWith(string compareTo) {
      if (_keyWord.Length != compareTo.Length)
        throw new DifferentWordLengthException();

      var length = _keyWord.Length;
      var firstWordChars = _keyWord.ToCharArray();
      var secondWordChars = compareTo.ToCharArray();
      var result = 0;

      for (int i = 0; i < length; i++) {
        if (firstWordChars[i].Equals(secondWordChars[i]))
          result++;
      }

      return result == length - 1;
    }

    public int CountDifferenceWith(string countDifferenceTo)
    {
      if (_keyWord.Length != countDifferenceTo.Length)
        throw new DifferentWordLengthException();

      var length = _keyWord.Length;
      var firstWordChars = _keyWord.ToCharArray();
      var secondWordChars = countDifferenceTo.ToCharArray();
      var result = 0;

      for (int i = 0; i < length; i++) {
        if (!firstWordChars[i].Equals(secondWordChars[i]))
          result++;
      }

      return result;
    }
  }
}