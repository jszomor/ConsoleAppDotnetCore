using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public class Sorts
  {
    private int[] Numbers;

    public Sorts(int[] numbers)
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

      while (left < right)
      {
        while (Numbers[right] >= pivot && left < right)
        {
          --right;
        }

        if (left != right)
        {
          Numbers[left] = Numbers[right];
          ++left;
        }

        while (Numbers[left] <= pivot && left < right)
        {
          ++left;
        }

        if (left != right)
        {
          Numbers[right] = Numbers[left];
          --right;
        }
      }

      Numbers[left] = pivot;
      pivot = left;
      left = lhold;
      right = rhold;

      if (left < pivot)
      {
        QuickSort(left, pivot - 1);
      }

      if (right > pivot)
      {
        QuickSort(pivot + 1, right);
      }
    }
  }


  //6,5,8,1,3,2,11
  public class QSort
  {
    public int[] _values;
    public QSort(int[] values)
    {
      _values = values;
    }

    public void QSorting()
    {
      Sorting(-1, 0);
    }

    public void Sorting(int i, int j)
    {
      int pivot = _values[_values.Length - 1];
      int lHold = i;
      int rHold = j;

      while (j < _values.Length - 1)
      {
        while (j < _values.Length - 1 && pivot <= _values[j])
        {
          j++;
        }
        i++;
        if (_values[i] != _values[j] && j < _values.Length - 1)
        {
          int temp = _values[i];
          _values[i] = _values[j];
          _values[j] = temp;
        }

      }

    }
  }
}
