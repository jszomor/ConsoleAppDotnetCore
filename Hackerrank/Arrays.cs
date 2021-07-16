using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
  public class Arrays
  {
    public void NewYearChaos()
    {
      int[] queue = new int[] { 1, 2, 5, 3, 7, 8, 6, 4 };
      //                        1, 2, 3, 4, 5, 6, 7, 8
      int bribes = 0;
      bool isTooChaotic = false;
      for (int i = 0; i < queue.Length; i++)
      {
        if (queue[i] - (i + 1) > 2)
        {
          Console.WriteLine("Too chaotic");
          isTooChaotic = true;
          break;
        }

        for (int j = Math.Max(0, queue[i] - 2); j < i; j++)
        {
          if (queue[j] > queue[i])
            bribes++;
        }

      }
      if(isTooChaotic == false)
      {
        Console.WriteLine(bribes);
      }
    }
  }
}
