using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoYouThinkYouCanLINQ
{

  public delegate void TransformDelegate(string num);

  public class SampleMethods
  {
    public static bool MyPredicate(int num)
    {
      return num % 2 == 0;
    }

    public static void Method1(string data)
    {
      Console.WriteLine(data + ": Method 1");
    }

    public static void Method2(string data)
    {
      Console.WriteLine(data + ": Method 2");
    }
  }


}
