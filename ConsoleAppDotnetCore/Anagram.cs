using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppDotnetCore
{

  public class Words
  {
    public string Word1 { get; set; }
    public string Word2 { get; set; }
    public Words(string word1, string word2)
    {
      Word1 = word1;
      Word2 = word2;
    }
  }

  public class Anagram
  {
    public bool CompareAnagram(Words words)
    {
      string w1 = OrderString(words.Word1);
      string w2 = OrderString(words.Word2);

      if (w1 == w2)
      {
        Console.WriteLine("Entered words are anagrams of each other!");
        return true;
      }
      else
      {
        Console.WriteLine("Entered words are not anagrams of each other!");
        return false;
      }
    }

    private string OrderString(string word) => string.Concat(word.ToLower().OrderBy(l => l));
  }
}
