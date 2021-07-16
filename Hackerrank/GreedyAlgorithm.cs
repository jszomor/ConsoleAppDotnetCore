using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
  class GreedyAlgorithm
  {
    public void MinimumAbsoluteDifference()
    {
      List<int> arr = new List<int>{ -59, -36, -13, 1, -53, -92, -2, -96, -54, 75 };

      long min = 100000000000000;
      int value;
      arr.Sort();

      #region Multiple loop
      //for (int i = 0; i < arr.Count; i++)
      //{
      //  for (int j = arr.Count-1; j > i; j--)
      //  {
      //    value = arr[i] - arr[j];
      //    value = Math.Abs(value);
      //    Console.WriteLine($"{value}, i:{i}, j:{j}");

      //    if(value < min)
      //    {
      //      min = value;
      //    }
      //  }
      //  Console.WriteLine("------------");
      //}
      //Console.WriteLine(min);
      #endregion

      for (int i = 1; i < arr.Count; i++)
      {
        value = arr[i - 1] - arr[i];
        value = Math.Abs(value);

        if(value < min)
        {
          min = value;
        }
      }
      Console.WriteLine(min);
    }

    public int LuckBalance()
    {
      int k = 3;
      List<List<int>> contests = new List<List<int>>()
      {
        new List<int> {5, 1},
        new List<int> {2, 1},
        new List<int> {1, 1},
        new List<int> {8, 1},
        new List<int> {10, 0},
        new List<int> {5, 0}
      };

      int luck = 0;
      var sortedList = contests.OrderByDescending(n => n[0]).ToList();
      for (int i = 0; i < contests.Count; i++)
      {
        if(sortedList[i][1] == 1)
        {
          if(k > 0)
          {
            luck += sortedList[i][0];
            k--;
          }
          else
          {
            luck -= sortedList[i][0];
          }
        }
        else
        {
          luck += sortedList[i][0];
        }
      }

      return luck;
    }

    public void GreedyFlorist()
    {
      int people = 3;
      int numberOfBuy = 1;
      int[] flowers = new int[] { 1, 3, 5, 7, 9 };
      flowers = flowers.OrderByDescending(n => n).ToArray();
      int totalCost = 0;
      int round;
      for (int i = 0; i < flowers.Length; i++)
      {
        round = i % people;
        if (round == 0 && people <= i)
        {
          numberOfBuy++;
        }

        totalCost += flowers[i] * numberOfBuy;
      }

      Console.WriteLine(totalCost);
    }

    public void MaxMin()
    {
      int maxMinArrayLength = 5;
      int[] totalArray = new int[] { 4504, 1520, 5857, 4094, 4157, 3902, 822, 6643, 2422, 7288, 8245, 9948, 2822, 1784, 7802, 3142, 9739, 5629, 5413, 7232 };

      Array.Sort(totalArray);
      int minUnfairness = 1000000000;
      for (int i = 0; i < totalArray.Length - maxMinArrayLength + 1; i++)
      {
        if(totalArray[i + maxMinArrayLength - 1] - totalArray[i] < minUnfairness)
        {
          minUnfairness = totalArray[i + maxMinArrayLength - 1] - totalArray[i];
        }
      }

      Console.WriteLine(minUnfairness);
    }
  }
}
