using System;
using System.Collections.Generic;
using System.Text;

namespace InterView
{
  public class ZabZab  {

    public static int DoZabzab(out int abc, Func<int, int> action)
    {
      abc = 10;

      return action(20) + abc;
    }

    public static int Cba(int jojo)
    {
      return jojo * jojo;
    }
  }
}
