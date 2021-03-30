using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDotnetCore
{
  public class WeekOfCode25
  {
    public static List<int> primes;  

    public static void _2_AppendAndDelete(string s, string t, int k)
    {
      var s1 = s.Trim();
      var t2 = t.Trim();
      //var k = Convert.ToInt32(Console.ReadLine());

      var commonString = 0;
      for (int i = 0; i < Math.Min(s1.Length, t2.Length) && s1[i] == t2[i]; i++)
      {
        commonString++;
      }

      var minOps = (s1.Length - commonString) + (t2.Length - commonString);

      if (k < minOps)
      {
        Console.WriteLine("No");
        return;
      }

      if (k == minOps) // || (k - minOps) % 2 == 0)
      {
        Console.WriteLine("Yes");
        return;
      }

      if (t2.Length + s1.Length <= k)
      {
        Console.WriteLine("Yes");
        return;
      }

      Console.WriteLine("No");
    }

    public static void _1_Between_Two_Sets()
    {
      Console.ReadLine();
      var divisors = Console.ReadLine().Trim().Split(' ').Select(nm => Convert.ToInt64(nm)).ToList();
      var divisees = Console.ReadLine().Trim().Split(' ').Select(nm => Convert.ToInt64(nm)).ToList();
      var count = 0;

      for (int i = 1; i <= 100; i++)
      {
        if (divisors.All(d => i % d == 0) && divisees.All(d => d % i == 0))
        {
          count++;
        }
      }

      Console.WriteLine(count);
    }

    public static List<int> FindFactors(int num)
    {
      if (primes == null)
      {
        primes = GeneratePrimes(100);
      }

      var res = new List<int>();

      var currentPrimePointer = 0;

      while (num > 1)
      {
        while (num % primes[currentPrimePointer] == 0)
        {
          res.Add(num);
          num /= primes[currentPrimePointer];
        }

        currentPrimePointer++;
      }

      return res;
    }

    public static List<int> GeneratePrimes(int maxSize)
    {
      var nums = new bool[maxSize];
      var res = new List<int>();

      for (int i = 2; i < maxSize; i++)
      {
        if (!nums[i])
        {
          res.Add(i);
          for (int y = i; y < maxSize; y += i)
          {
            nums[y] = true;
          }
        }
      }

      return res;
    }
  }
}