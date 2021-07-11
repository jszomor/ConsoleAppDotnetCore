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
  }
}
