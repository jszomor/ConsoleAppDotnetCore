using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

      System.Array.Sort(words);
      string check = null;
      for (int i = 0; i < words.Length; i++)
      {
        int count = 1;
        for (int j = i + 1; j < words.Length; j++)
        {
          if (words[i] == words[j])
          {
            count++;
          }
          else break;
        }
        if (words[i] != check)
        {
          Console.WriteLine($"{words[i]}, {count}");
          check = words[i];
        }
      }
    }

    public static void FindSpecificWordInCollectionLINQ()
    {
      string text = @"Historically, the world of data and the world of objects" +
          @" have not been well integrated. Programmers work in C# or Visual Basic" +
          @" and also in SQL or XQuery. On the one side are concepts such as classes," +
          @" objects, fields, inheritance, and .NET APIs. On the other side" +
          @" are tables, columns, rows, nodes, and separate languages for dealing with" +
          @" them. Data types often require translation between the two worlds; there are" +
          @" different standard functions. Because the object world has no notion of query, a" +
          @" query can only be represented as a string without compile-time type checking or" +
          @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
          @" objects in memory is often tedious and error-prone.";

      string searchTerm = "data";

      //Convert the string into an array of words  
      string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

      // Create the query.  Use ToLowerInvariant to match "data" and "Data"
      var matchQuery = from word in source
                       where word.ToLowerInvariant() == searchTerm.ToLowerInvariant()
                       select word;

      // Count the matches, which executes the query.  
      int wordCount = matchQuery.Count();
      Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", wordCount, searchTerm);

      // Keep console window open in debug mode  
      Console.WriteLine("Press any key to exit");
      Console.ReadKey();
    }

    public static void CountWordDict()
    {
      string text = @"Historically, the world of data and the world of objects" +
          @" have not been well integrated. Programmers work in C# or Visual Basic" +
          @" and also in SQL or XQuery. On the one side are concepts such as classes," +
          @" objects, fields, inheritance, and .NET APIs. On the other side" +
          @" are tables, columns, rows, nodes, and separate languages for dealing with" +
          @" them. Data types often require translation between the two worlds; there are" +
          @" different standard functions. Because the object world has no notion of query, a" +
          @" query can only be represented as a string without compile-time type checking or" +
          @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
          @" objects in memory is often tedious and error-prone.";

      string[] source = text.ToLower().Split(new char[] { '.', ',', ' ', '?', '!', '/' }, StringSplitOptions.RemoveEmptyEntries);

      var statistics = new Dictionary<string, int>();

      foreach (var word in source)
      {
        if (!statistics.ContainsKey(word))
        {
          statistics.Add(word, 1);
        }
        else
        {
          statistics[word] += 1;
        }
      }

      statistics = statistics.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine($"{statistics.ElementAt(i).Key}: {statistics.ElementAt(i).Value}");
      }
    }

    public static void WordCountLINQ()
    {
      string text = @"Historically, the world of data and the world of objects" +
          @" have not been well integrated. Programmers work in C# or Visual Basic" +
          @" and also in SQL or XQuery. On the one side are concepts such as classes," +
          @" objects, fields, inheritance, and .NET APIs. On the other side" +
          @" are tables, columns, rows, nodes, and separate languages for dealing with" +
          @" them. Data types often require translation between the two worlds; there are" +
          @" different standard functions. Because the object world has no notion of query, a" +
          @" query can only be represented as a string without compile-time type checking or" +
          @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
          @" objects in memory is often tedious and error-prone.";

      string[] source = text.ToLower().Split(new char[] { '.', ',', ' ', '?', '!', '/' }, StringSplitOptions.RemoveEmptyEntries);

      var query = (from i in source
                   group i by i into g
                   orderby g.Count() descending
                   select new { Key = g.Key, Count = g.Count() }).ToList();

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine(source[i]);
      }
    }

    public static void WordCountLINQ2()
    {
      string[] texts = new string[]
      { 
        @"Historically, the world of data and The world of objects" +
        @" have not been well integrated. Programmers work in C# or Visual Basic" +
        @" and also in SQL or XQuery. On the one side are concepts such as classes," +
        @" objects, fields, inheritance, and .NET APIs. On the other side" +
        @" are tables, columns, rows, nodes, and separate languages for dealing with" +
        @" them. Data types often require translation between the two worlds; there are" +
        @" different standard functions. Because the object world has no notion of query, a" +
        @" query can only be represented as a string without compile-time type checking or" +
        @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
        @" objects in memory is often tedious and error-prone."
      };

      var result = (from line in texts
                     let words = line.ToLower().Split(new char[] { '.', ',', ' ', '?', '!', '/', ';' }, StringSplitOptions.RemoveEmptyEntries)
                     from word in words
                     group word by word into g
                     orderby g.Count() descending
                     select new { Word = g.Key, Occurance = g.Count() }).ToList();

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine(result[i]);
      }
    }
  }
}
