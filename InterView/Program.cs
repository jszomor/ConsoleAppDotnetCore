﻿using InterView.CtorSample;
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

      //LookAndSay.Look();


      //Console.WriteLine("Enter number:");

      //int number = 10;

      //while (number < 100)
      //{
      //  string result = EventPractice.Call(number, "EUR");
      //  number = Convert.ToInt32(Console.ReadLine());

      //  Console.WriteLine(result);
      //}



      //BizzFuzz.Solution1();

      //CoinChallenge.Solution1();


      //var values = new int[] { 4, 12, 54, 22, 99, 76, 34 };
      //BubbleSort.SortTheBubble(values);

      //StringsWorker.SplitString("AlmaKörteBanán");

      //Console.WriteLine(FibonacciFactory.FibRec(10));

      Cube.DropCube();

      Console.ReadKey();

    }
  }
}
