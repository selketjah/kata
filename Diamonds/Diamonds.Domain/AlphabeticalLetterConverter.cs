namespace Diamonds.Domain
{
  public class AlphabeticalLetterConverter
  {
    public int GetAlphabeticalValue(char letter)
    {
      return char.ToUpper(letter) - 64;
    }
  }
}