using System;
using System.Collections.Generic;
using System.Text;

namespace InterView
{
  public class CoinChallenge
  {
    public static void Solution1()
    {
      int number = 4;

      int[] coins = new int[] {1,2};

      int currentIndex = 0;

      Console.WriteLine(CalculateCombos(coins, number, currentIndex));

    }

    private static int CalculateCombos(int[] coins, int number, int currentIndex)
    {
      if(number == 0)
      {
        return 1;
      }
      else if(number < 0)
      {
        return 0;
      }

      int combos = 0;

      for (int i = currentIndex; i < coins.Length; i++)
      {
        combos += CalculateCombos(coins, number - coins[i], i);
      }

      return combos;
    }
  }
}
