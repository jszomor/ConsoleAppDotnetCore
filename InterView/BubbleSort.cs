using System;
using System.Collections.Generic;
using System.Text;

namespace InterView
{
  public class BubbleSort
  {
    public static void SortTheBubble(int[] values)
    {
      for (int i = 0; i < values.Length; i++)
      {
        for (int j = values.Length - 1; i < j; j--)
        {
          if(values[i] > values[j])
          {
            int temp = values[i];
            values[i] = values[j];
            values[j] = temp;
          }
        }
      }

      Array.ForEach(values, (value) => Console.WriteLine(value));
    }
  }
}
