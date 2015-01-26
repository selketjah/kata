namespace Kata.Euler
{
  public class MultiplesOfThreeAndFive
  {
    public int Sum(int endValue)
    {
      var sum = 0;

      for (int i = 0; i < endValue; i++) {
        if (i % 3 == 0) sum += i;
        else if (i % 5 == 0) sum += i;
      }

      return sum;
    }
  }
}