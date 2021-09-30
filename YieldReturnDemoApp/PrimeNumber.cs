using System;
using System.Collections.Generic;

namespace YieldReturnDemoApp
{
  public class PrimeNumber
  {

    public static void GetPrimeNumber()
    {
      int value = 1;
      while(value < 30)
      {
        if(CheckNumber(value))
        {
          Console.WriteLine(value);
        }

        value++;
      }
    }
    
    public static bool CheckNumber(int value)
    {
      bool isPrime = true;

      for (int i = 2; i <= value / 2; i++)
      {
        if(value % i == 0)
        {
          Console.WriteLine(i);
          //isPrime = false;
          //return isPrime;
        }
      }

      return isPrime;
    }
  }
}
