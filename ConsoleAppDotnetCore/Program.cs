using System;

namespace ConsoleAppDotnetCore
{
  class Program
  {
    static void Main(string[] args)
    {
      //Occurrences.CountWordOccurencyForLoop();

      //Occurrences.FindSpecificWordInCollectionLINQ();

      //Occurrences.CountWordDict();

      int[] numbers = new int[] { 10, 1, 4, 6, 6, 3, 9, 12 };

      var binaryTree = new BinaryTree(numbers);
      binaryTree.InOrder(binaryTree.Print);

      //var aaronjwood = new aaronjwoodBinarySearchTree.BinarySearchTree();
      //aaronjwood.Start();

      //var quickSort = new MyArray(numbers);

      //quickSort.Sort();

      //foreach (var item in numbers)
      //{
      //  Console.WriteLine(item);
      //}


      //var anag = new Anagram();
      //anag.Start(anag);

      //Occurrences.WordCountLINQ2();

      //string input = "haveaniceday";

      //Console.WriteLine(Practice.Encryption(input));

      //abchgfeaaaa

      //no >>> dcba
      //no >>> dcbb

      //string input2 = "dcbb";

      //Console.WriteLine(Practice.TheBiggerIsGreater2(input2));

      //var practice = new Practice();

      //string s = "aaaaaaaaaa"; //"asdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv"; // "hackerhappy"; //Console.ReadLine();

      //string t = "aaaaa"; //"asdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv"; //"hackerrank"; //Console.ReadLine();

      //int k = 7; //9;  //Convert.ToInt32(Console.ReadLine());


      //string result = practice.AppendAndDelete(s, t, k);

      //Console.WriteLine(result);
      //Console.WriteLine("Hello World!");

      //WeekOfCode25._2_AppendAndDelete(s, t, k);
    }
  }
}
