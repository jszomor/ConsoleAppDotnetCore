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
      if (isTooChaotic == false)
      {
        Console.WriteLine(bribes);
      }
    }

    public class MinimumSwap2
    {
      public void CallQuickSort()
      {
        int[] arr = new int[] { 7, 1, 3, 2, 4, 5, 6 };

        QuickSort(arr, 0, arr.Length-1);
      }


      public void QuickSort(int[] arr, int start, int end)
      {
        if (start >= end)
          return;

        int index = Partition(arr, start, end);

        QuickSort(arr, start, index - 1);
        QuickSort(arr, index + 1, end);
      }

      public int Partition(int[] arr, int start, int end)
      {
        //{ 7, 1, 3, 2, 4, 5, 6 };
        int pivotValue = arr[end];
        int pivotIndex = start;

        for (int i = 0; i < end; i++)
        {
          if (arr[i] < pivotValue)
          {
            Swap(arr, i, pivotIndex);
            pivotIndex++;
          }
        }
        Swap(arr, pivotIndex, end);

        return pivotIndex;
      }

      public void Swap(int[] arr, int a, int b)
      {
        int temp;
        temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
      }

      public void Xyz()
      {
        int[] queue = new int[] { 1, 2, 5, 3, 7, 8, 6, 4 };

        int pivotValue = queue[queue.Length - 1];
        int pivotIndex = 0;

        for (int i = 0; i < queue.Length; i++)
        {
          if(pivotValue > queue[i])
          {
            Swap(queue, i, pivotIndex);
            pivotIndex++;
          }
        }

        Swap(queue, queue.Length - 1, pivotIndex);
      }
    }
  }
}
