using System;
using System.Collections.Generic;
using System.Text;

namespace InterView
{
  public class CoinChallenge
  {
    public static void Solution1()
    {
      int number = 2325;

      int[] coins = new int[] {5,10,20,50,100,200};

      int currentIndex = 0;

      Console.WriteLine(CalculateCombos(coins, number, currentIndex));

      Console.WriteLine();

      Console.WriteLine(GetNumberOfWays(coins, number));

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

    private static int GetNumberOfWays(int[] coins, int number)
    {
      // Create the ways array to 1 plus the amount
      // to stop overflow
      int[] ways = new int[number + 1];

      // Set the first way to 1 because its 0 and
      // there is 1 way to make 0 with 0 coins
      ways[0] = 1;

      // Go through all of the coins
      for (int i = 0; i < coins.Length; i++)
      {
        // Make a comparison to each index value
        // of ways with the coin value.
        for (int j = 0; j < ways.Length; j++)
        {
          if(coins[i] <= j)
          {
            // Update the ways array
            ways[j] += ways[j - coins[i]];
          }
        }
      }

      return ways[number];
    }
  }
}
