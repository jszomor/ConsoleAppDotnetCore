using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Search
{
  public class TripleSum
  {
    public int[] A_array = new int[] { 1, 2, 3, 55, 78 }; // 1, 2, 3, 4, 5, 6, 7, 8 }; // 2, 3, 5, 1, 6, 9, 11, 3 };
    public int[] B_array = new int[] { 30, 60 }; // 5, 6, 7, 8, 9, 10, 11, 12 }; // 2, 3, 5, 1, 6, 9, 11, 3 };
    public int[] C_array = new int[] { 25, 28, 32 }; // 3, 4, 5, 6, 7, 8, 9, 10 }; // 2, 3, 5, 1, 6, 9, 11, 3 };

    public long Triplets ()
    {
      //A[i] <= B[j] >= C[k]

      int j = 0;
      //int i = 0;
      int k = 0;

      int result = 0;

      for (int i = 0; i < B_array.Length; i++)
      {
        while (A_array[j] <= B_array[i])
        {
          j++;          
        }

        while (B_array[i] >= C_array[k] && )
        {
          k++;
        }

        result += j * k;
      }

      return result;
    }
  }
}
