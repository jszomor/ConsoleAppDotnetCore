using System;
using System.Collections.Generic;
using System.Text;

namespace InterView
{
  public delegate int TestDelegate(int x);

  public class DelegatePractice
  {

    public static int Pow(int x)
    {
      return x * x;
    }

    public static int Add(int x)
    {
      return x + x;
    }

    public static void Call()
    {
      TestDelegate t = Pow;
      Console.WriteLine(t.Invoke(3));

      t += Add;
      t -= Add;
      Console.WriteLine(t.Invoke(3));
    }
  }

  public class Util
  {
    public static void Transform(int[] values, TestDelegate t)
    {
      for (int i = 0; i < values.Length; i++)
      {
        values[i] = t(values[i]);
      }
    }

    public static void Call()
    {
      int[] values = new int[] { 1, 2, 3 };

      Transform(values, DelegatePractice.Pow);

      foreach (var item in values)
      {
        Console.WriteLine(item);
      }
    }
  }
}
