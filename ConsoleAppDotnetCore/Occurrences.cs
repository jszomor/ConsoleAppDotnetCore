using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public static class Occurrences
  {
    public static void CountWordOccurencyForLoop()
    {
      string[] words =
      {
          "which",
          "wristwatches",
          "are",
          "wristwatches",
          "wristwatches",
          "swiss",
          "wristwatches",
          "which",
          "are",
          "are",
          "wristwatches",
      };

      Array.Sort(words);
      string check = null; 
      for (int i = 0; i < words.Length; i++)
      {
        int count = 1;
        for (int j = i+1; j < words.Length; j++)
        {
          if (words[i] == words[j])
           {
            count++;
          }
          else break;
        }
        if(words[i] != check)
        {
          Console.WriteLine($"{words[i]}, {count}");
          check = words[i];
        }
      }
    }
  }
}
