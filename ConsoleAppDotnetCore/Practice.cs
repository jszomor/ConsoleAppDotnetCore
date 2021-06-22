using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public static class Practice
  {
    public static string Encryption(string input)
    {

      //string input = "haveaniceday";
      //output: hae and via ecy

      //feedthedog
      //fto ehg ee dd

      //chillout
      //clu hlt io

      double L = Math.Sqrt(input.Length);
      Console.WriteLine(L);

      var builder = new StringBuilder();
      int column = Convert.ToInt32(Math.Ceiling(L));
      int row = Convert.ToInt32(Math.Floor(L));
      for (int j = 0; j < column; j++)
      {
        for (int i = j; i < input.Length; i+=column)
        {
          builder.Append(input[i]);
        }
        builder.Append(" ");
      }

      return Convert.ToString(builder);
    }

    public static string TheBiggerIsGreater(string input)
    {
      //abchgfeaaaa
      //dkhc
      //no >>> dcba
      //no >>> dcbb

      var inputArray = input.ToCharArray();

      int pivot = input.Length - 1;

      // Find longest non-increasing suffix
      while (pivot > 0 && input[pivot] <= input[pivot - 1])
      {
        pivot--;
      }
      // Now pivot is the head index of the suffix

      // Are we at the last permutation already?
      if (pivot <= 0)
      {
        return "no answer";
      }

      // Let array[pivot - 1] be the real pivot
      // Find rightmost element greater than the pivot
      char temp;
      int j = input.Length - 1;
      while (inputArray[pivot - 1] >= inputArray[j])
      {
        j--;
      }

      // Swap the pivot with j
      temp = inputArray[pivot - 1];
      inputArray[pivot - 1] = inputArray[j];
      inputArray[j] = temp;

      // Reverse the suffix
      int swap = input.Length - 1;
      while (pivot < swap)
      {
        temp = inputArray[pivot];
        inputArray[pivot] = inputArray[swap];
        inputArray[swap] = temp;
        pivot++;
        swap--;
      }


      return new string(inputArray);
    }

    public static bool CheckAnagram(string word1, string word2)
    {
      string w1 = StringConcat(word1);
      string w2 = StringConcat(word2);

      if (w1 == w2) return true;
      else return false;
    }

    public static string StringConcat(string word) => string.Concat(word.ToLower().OrderBy(l => l));

    public static void CountWordOccuranceDict(string[] words)
    {
      var myWords = new Dictionary<string, int>();

      words = Array.ConvertAll(words, l => l.ToLower());

      words = words.Select(l => l.ToLower()).ToArray();

      words = (from word in words select word.ToLower()).ToArray();

      foreach (var word in words)
      {
        if(!myWords.ContainsKey(word))
        {
          myWords.Add(word, 1);
        }
        else
        {
          myWords[word] += 1; // gyakorolni
        }
      }

      myWords = myWords.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine($"{myWords.ElementAt(i).Key}, {myWords.ElementAt(i).Value}");
      }
    }

    public static void CountOccuranceLINQ(string[] words)
    {
      var query = (from word in words
                  let customWord = word.ToLower()
                  group customWord by customWord into g
                  orderby g.Count() descending
                  select new { key = g.Key, Count = g.Count() }).ToList();

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine(query[i]);
      }                  
    }

    public static int FibonacciRec(int n)
    {
      if (n < 2)
      {
        return n;
      }
      else
      {
        return FibonacciRec(n - 1) + FibonacciRec(n - 2);        
      }
    }

    public static double FibonacciLoop(double n)
    {
      if (n < 0) throw new InvalidOperationException("No negative number is allowed.");

      if (n < 2) return 1;

      var (a, b) = (1, 1);

      while(n > 2)
      {
        b += a;
        a = b - a;
        n--;
      }

      return b;
    }

    public static double FactorialRec(int number)
    {

      if (number == 0)
        return 1;

      double factRecValue = FactorialRec(number - 1);

      double fact = number * factRecValue;

      return fact;
    }

    public static double FactorialLoop(int number)
    {

      if (number == 0)
        return 1;

      double factorial = 1;
      double count = number - (number - 1);

      while (count < number)
      {
        factorial *= (count + 1);
        count++;
      }

      return factorial;
    }

    public static double FactorialYoutubeKudvenkat(int number)
    {
      if(number == 0)
      {
        return 1;
      }

      double factorial = 1;

      for (int i = number; i > 0; i--)
      {
        factorial *= i;
      }
      return factorial;
    }

    public static double FibSimple(int number)
    {
      if (number < 2)
        return 1;

      var (a, b) = (1, 1);

      while(number > 2)
      {
        b += a;
        a = b - a;
        number--;
      }
      return b;
    }
  }
}
