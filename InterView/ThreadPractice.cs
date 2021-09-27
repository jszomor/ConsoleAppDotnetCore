using System;
using System.Collections.Generic;
using System.Text;

namespace InterView
{
  public class ThreadPractice
  {
    public static int i;

    public static void ThreadProc()
    {
      System.Console.WriteLine(i++);
    }
  }
}
