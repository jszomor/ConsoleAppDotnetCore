using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace InterView
{
  /*   
    Készíteni kell egy algoritmust ami leirja egy számsorozatról hogy melyik elemből hány darab található és azt visszadja. 
    Az első szám a darabaszámot mutatja a második azt a számot amit megszámoltunk.  

    A zárójelben szereplő segítség mindig ez előzős sorra utal
    1 (1)
    11 (1db 1-es) '11'
    21 (2db 1-es) '21'
    1211 (1db 2-es, 1db 1-es) '12 11'
    111221 (1db 1-es, 1db 2-es, 2db 1-es) '11 12 21'
  */

  public class LookAndSay
  {
    public void Look()
    {
      string input = "1";

      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      for (int i = 0; i < 10000000; i++)
      {
        LookSubString(input);
      }
      stopwatch.Stop();
      TimeSpan ts = stopwatch.Elapsed;
      Console.WriteLine($"{ts.Milliseconds} milliseconds elapsed for LookSubString function.");

      stopwatch.Start();
      for (int i = 0; i < 10000000; i++)
      {
        LookDoubleLoop(input);
      }
      stopwatch.Stop();
      ts = stopwatch.Elapsed;
      Console.WriteLine($"{ts.Milliseconds} milliseconds elapsed for LookDoubleLoop function.");
    }

    private string LookDoubleLoop(string input)
    {
      var sb = new StringBuilder();

      int i;
      int counter = 1;

      if (input == null || string.IsNullOrEmpty(input))
      {
        return "";
      }

      for (i = 0; i < input.Length; i++)
      {
        while (input.Length > i + 1 && input[i] == input[i + 1])
        {
          i++;
          counter++;
        }
        sb.Append($"{counter}").Append($"{input}", i, 1);
        counter = 1;
      }

      return sb.ToString();
    }

    private string LookSubString(string input)
    {
      var sb = new StringBuilder();

      if (input == null || string.IsNullOrEmpty(input))
      {
        return "";
      }

      int marker = 0;

      for (int i = 0; i < input.Length; i++)
      {
        if (input.IndexOf(input[marker]) != input.IndexOf(input[i]))
        {
          string digitsTotal = input.Substring(marker, i - marker);
          sb.Append(digitsTotal.Length).Append(input[marker]);
          marker = i;
        }
      }

      string subS = input.Substring(marker, input.Length - marker);

      sb.Append(subS.Length).Append(input[marker]);

      return sb.ToString();
    }
  }
}
