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
      string w1 = ToLowerString(words.Word1);
      string w2 = ToLowerString(words.Word2);

      int equal = string.Compare(w1, w2);

      if (equal == 0)
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

    private string ToLowerString(string word) => string.Concat(word.ToLower().OrderBy(l => l));

    public void Start(Anagram anag)
    {
      while (true)
      {
        Console.WriteLine("Enter the first word.");
        string word1 = Console.ReadLine();
        Console.WriteLine("Enter the second word.");
        string word2 = Console.ReadLine();

        Words words = new Words(word1, word2);
        
        anag.CompareAnagram(words);
        string answer;
        while (true)
        {
          Console.WriteLine("Wants to try again?(Y/N)");
          answer = Console.ReadLine();

          if (answer != "Y" && answer != "N")
          {
            Console.WriteLine("Invalid answer. Please select letter [Y] for keep continue or letter [N] for exit");
          }
          else
            break;
        }

        if (answer == "N")
          break;
      }
    }
  }
}
