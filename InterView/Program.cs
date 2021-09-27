using InterView.CtorSample;
using InterView.InterfacePractice;
using System;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading;

namespace InterView
{
  class Program
  {
    static void Main(string[] args)
    {

      //for (int i = 0; i < 4; i++)
      //{
      //  Thread t = new Thread(new ThreadStart(ThreadPractice.ThreadProc));
      //  t.Start();
      //}

      //String b = new String("szoveg");
      //String a = new String("szoveg");

      //Console.WriteLine(a == b);


      //var child = new Child();

      //var doSome = new DoSomething();

      //var myObject = new DoSomething();
      //myObject.f();
      //myObject.g();

      var ls = new LookAndSay();
      ls.Look();
      


      Console.ReadKey();

    }
  }
}
