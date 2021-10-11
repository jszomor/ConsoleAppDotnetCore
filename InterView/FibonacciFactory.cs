using System;
using System.Collections.Generic;
using System.Text;

namespace InterView
{
  public class FibonacciFactory
  {
    // 1 1 2 3 5 8 13 21 34 55
    public static int Fib(int n)
    {
      if(n < 3)
      {
        return n;
      }

      var (a, b) = (1, 1);

      while(n >= 3)
      {
        b += a;
        a = b - a;

        n--;
      }

      return b;
    }

    public static int FibRec(int n)
    {
      if(n < 2)
      {
        return n;
      }

      int result = FibRec(n - 2) + FibRec(n - 1);

      return result;
    }
  }
}
