using System;
using System.Collections.Generic;
using System.Text;

namespace InterView
{
  public class BizzFuzz
  {
    public static void Solution1()
    {      
      var r = new Random();

      var numbers = new byte[100];

      r.NextBytes(numbers);

      foreach (var item in numbers)
      {
        if (item % 3 == 0 && item % 5 == 0)
        {
          Console.WriteLine($"BizzFuzz - osztó a 3 és az 5 - vizsgált szám {item} ");
        }
        else if (item % 3 == 0)
        {
          Console.WriteLine($"Bizz - osztó a 3 - vizsgált szám {item} ");
        }
        else if (item % 5 == 0)
        {
          Console.WriteLine($"Fuzz - osztó az 5 - vizsgált szám {item} ");
        }
      }
    }
  }
}
