using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace InterView
{
  /*   
    Look & Say
    Készíteni kell egy algoritmust ami megszámolja egy karaktersorozat egyes elemeit,
    hogy melyikből hány darab található majd kiegészíti a darabszámot vele és azt visszadja. 
    Az első szám a darabaszámot mutatja a második azt a számot amit megszámoltunk.  

    A zárójelben szereplő segítség mindig ez előzős sorra utal
    1
    11 (1db 1-es) '11'
    21 (2db 1-es) '21'
    1211 (1db 2-es, 1db 1-es) '12 11'
    111221 (1db 1-es, 1db 2-es, 2db 1-es) '11 12 21'
  */

  public class LookAndSay
  {
    static int Loop = 1;

    public static void Look()
    {
      string input = "1";

      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();

      Look(input);

      stopwatch.Stop();
      TimeSpan ts = stopwatch.Elapsed;
      Console.WriteLine($"{ts.Milliseconds} millisecond.");

    }

    private static string Look(string input)
    {
      var sb = new StringBuilder();

      if (input == null || string.IsNullOrEmpty(input) || Loop == 60)
      {
        return null;
      }

      int marker = 0;

      for (int i = 0; i < input.Length; i++)
      {
        if (input[marker] != input[i])
        {
          sb.Append(i - marker).Append(input[marker]);
          marker = i;
        }
      }
      sb.Append(input.Length - marker).Append(input[marker]);
      //Console.WriteLine(sb);
      Loop++;
      return Look(sb.ToString());
    }
  }
}
