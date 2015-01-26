using System.IO;

namespace WordChainPuzzle.Domain
{
  public class WordChainFileReader
  {
    public string[] LoadDictionary(string filePath)
    {
      using (var sr = new StreamReader(filePath)) {
        string words = sr.ReadToEnd();
        return words.Split('\n');
      }
    }
  }
}