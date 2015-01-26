namespace WordChainPuzzle.Domain
{
  public class OneLetterDifferentWordComparer {
    private readonly string _keyWord;
    private readonly string _compareTo;

    public OneLetterDifferentWordComparer(string keyWord, string compareTo) {
      _keyWord = keyWord;
      _compareTo = compareTo;
    }

    public bool Compare() {
      if (_keyWord.Length != _compareTo.Length)
        throw new DifferentWordLengthException();

      var length = _keyWord.Length;
      var firstWordChars = _keyWord.ToCharArray();
      var secondWordChars = _compareTo.ToCharArray();
      var result = 0;

      for (int i = 0; i < length; i++) {
        if (firstWordChars[i].Equals(secondWordChars[i]))
          result++;
      }

      return result == length - 1;
    }

    public int CountDifference()
    {
      if (_keyWord.Length != _compareTo.Length)
        throw new DifferentWordLengthException();

      var length = _keyWord.Length;
      var firstWordChars = _keyWord.ToCharArray();
      var secondWordChars = _compareTo.ToCharArray();
      var result = 0;

      for (int i = 0; i < length; i++) {
        if (!firstWordChars[i].Equals(secondWordChars[i]))
          result++;
      }

      return result;
    }
  }
}