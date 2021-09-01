using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Search
{
  public class TripleSum
  {
    public int[] a = new int[] { 5, 4, 1 }; // 1, 2, 3, 4, 5, 6, 7, 8 }; // 2, 3, 5, 1, 6, 9, 11, 3 };
    public int[] b = new int[] { 3, 3, 2 }; // 5, 6, 7, 8, 9, 10, 11, 12 }; // 2, 3, 5, 1, 6, 9, 11, 3 };
    public int[] c = new int[] { 1, 3, 2 }; // 3, 4, 5, 6, 7, 8, 9, 10 }; // 2, 3, 5, 1, 6, 9, 11, 3 };

    public long Triplets ()
    {
      a = a.Distinct().ToArray();
      b = b.Distinct().ToArray();
      c = c.Distinct().ToArray();

      Array.Sort(a);
      Array.Sort(b);
      Array.Sort(c);

      int j = 0;
      int k = 0;

      int result = 0;

      for (int i = 0; i < b.Length; i++)
      {
        while (a.Length > j && a[j] <= b[i])
        {
          j++;          
        }

        while (c.Length > k && b[i] >= c[k])
        {
          k++;
        }

        result += j * k;
      }

      return result;
    }
  }
}
