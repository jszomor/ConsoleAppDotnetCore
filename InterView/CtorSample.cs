using System;
using System.Collections.Generic;
using System.Text;

namespace InterView
{
  namespace CtorSample
  {
    public class Base
    {
      public Base()
      {
        Console.WriteLine("Base()");
      }

      static Base()
      {
        Console.WriteLine("static Base()");
      }
    }

    public class Child : Base
    {
      public Child()
      {
        Console.WriteLine("Child()");
      }

      static Child()
      {
        Console.WriteLine("static Child()");
      }
    }
  }
}
