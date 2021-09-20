using System;
using System.Collections.Generic;
using System.Linq;

namespace YieldReturnDemoApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var results = Generators.PrimeNumber().Take(11);

      foreach (var item in results)
      {
        Console.WriteLine(item);
      }

      Console.ReadKey();
    }
  }


  public class Generators
  {
    public static IEnumerable<int> PrimeNumber()
    {
      int counter = 1;

      while(true)
      {
        if(IsPrimeNumber(counter))
        {
          yield return counter;
        }

        counter++;
      }
    }

    private static bool IsPrimeNumber(int value)
    {
      bool isPrime = true;

      for (int i = 2; i < value / 2; i++)
      {
        if(value % i == 0)
        {
          isPrime = false;
          break;
        }
      }

      if(value == 4)
      {
        isPrime = false;
      }

      return isPrime;
    }
  }

}
