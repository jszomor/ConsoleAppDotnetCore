using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
  public class Sorting
  {
    public void FraudulentActivityNotifications()
    {
      int d = 5;

      int notification = 0;
      int[] expenditure = new int[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 };
      double[] arr = new double[d];

      Array.Copy(expenditure, arr, d);
      Array.Sort(arr);

      double median;

      for (int i = 0; i < expenditure.Length - d; i++)
      {

        if (arr.Length % 2 == 0)
        {
          median = (arr[(arr.Length / 2 - 1)] + arr[(arr.Length / 2)]) / 2;
        }
        else
        {
          median = arr[arr.Length / 2];
        }

        if (median * 2 <= expenditure[d + i])
        {
          notification++;
        }

        Array.Copy(expenditure, expenditure.GetLowerBound(0) + (i + 1), arr, arr.GetLowerBound(0), d - 1);
        Array.Sort(arr);

      }
      Console.WriteLine(notification);
    }

    private double DefineMedian(int d, int[] expenditure, int border)
    {
      List<double> ls = new List<double>();
      for (int i = border; i < d + border; i++)
      {
        ls.Add(expenditure[i]);
      }
      ls.Sort();

      double result;

      if (ls.Count % 2 == 0)
      {
        result = (ls[(ls.Count / 2 - 1)] + ls[(ls.Count / 2)]) / 2;
      }
      else
      {
        result = ls[ls.Count / 2];
      }

      return result;
    }


    public void activityNotifications()
    {
      int d = 5;
      int[] expenditure = new int[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 };
      int result = 0;

      var arr = new int[d];
      Array.Copy(expenditure, arr, d);
      Array.Sort(arr);

      for (int i = d; i < expenditure.Length; i++)
      {
        if (expenditure[i] >= arr[d / 2] + arr[(d - 1) / 2])
        {
          result++;
        }

        int index = Array.BinarySearch(arr, expenditure[i - d]);
        Array.Copy(arr, index + 1, arr, index, d - index - 1);
        index = Array.BinarySearch(arr, 0, d - 1, expenditure[i]);
        index = index >= 0 ? index : ~index;
        Array.Copy(arr, index, arr, index + 1, d - index - 1);
        arr[index] = expenditure[i];
      }

      Console.WriteLine(result);

    }
  }
}
