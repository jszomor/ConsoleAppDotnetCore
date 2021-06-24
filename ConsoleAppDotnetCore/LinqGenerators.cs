using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public class LinqGenerators
  {
    private static Random random = new Random();

    public static IEnumerable<int> GenerateRandomNumbersMinMax (int min, int max, int numberOfElements)
    {
      return Enumerable.Range(0, numberOfElements - 1).Select(n => random.Next(min, max)).OrderBy(x => x.ToString());
    }

    public static string GetUniqueId(int charLength)
    {
      var charId = Enumerable.Range(0, charLength - 1).Select(n => (char)random.Next(1, 120));

      return new string(charId.ToArray());
    }

    public static string GetUniqueIdByArray(int idLength)
    {
      var idChars = new char[]
      {
        '0','1','2','3','4','5','6','7','8','9',
        'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
        'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
      };

      var result = Enumerable.Range(0, idLength - 1).Select(x => idChars[random.Next(0, idChars.Length - 1)]);

      return new string(result.ToArray());
    }

  }
}
