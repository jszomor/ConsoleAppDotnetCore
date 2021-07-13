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
      int[] expenditure = new int[] { 2, 3, 4, 2, 3, 6, 8, 4, 5};
      double median;
      for (int i = 0; i < expenditure.Length-d; i++)
      {
        median = DefineMedian(d, expenditure, i);
        if(median * 2 <= expenditure[d+i])
        {
          notification++;
        }
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
  }
}
