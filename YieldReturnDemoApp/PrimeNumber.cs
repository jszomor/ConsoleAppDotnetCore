using System;
using System.Collections.Generic;

namespace YieldReturnDemoApp
{
  public class PrimeNumber
  {

    public void GetPrimeNumber()
    {
      int i = 1;
      while(i < 30)
      {
        if(CheckNumber(i) && i != 4)
        {
          Console.WriteLine(i);
        }

        i++;
      }

      Console.ReadKey();
    }
    
    bool CheckNumber(int value)
    {
      bool isPrime = true;

      for (int i = 2; i < value / 2; i++)
      {
        if(value % i == 0)
        {
          isPrime = false;
          return isPrime;
        }
      }

      return isPrime;
    }
  }
}
