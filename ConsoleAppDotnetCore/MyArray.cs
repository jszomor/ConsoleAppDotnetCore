using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public class MyArray
  {
    private int[] Numbers;

    public MyArray(int[] numbers)
    {
      Numbers = numbers;
    }

    public void Sort()
    {
      QuickSort(0, Numbers.Length - 1);
    }

    private void QuickSort(int left, int right)
    {
      int pivot = Numbers[left];
      int lhold = left;
      int rhold = right;

      while(left < right)
      {
        while(Numbers[right] >= pivot && left < right)
        {
          --right;
        }

        if(left != right)
        {
          Numbers[left] = Numbers[right];
          ++left;
        }

        while(Numbers[left] <= pivot && left < right)
        {
          ++left;
        }

        if(left != right)
        {
          Numbers[right] = Numbers[left];
          --right;
        }
      }

      Numbers[left] = pivot;
      pivot = left;
      left = lhold;
      right = rhold;

      if(left < pivot)
      {
        QuickSort(left, pivot - 1);
      }

      if(right > pivot)
      {
        QuickSort(pivot + 1, right);
      }
    }
  }
}
