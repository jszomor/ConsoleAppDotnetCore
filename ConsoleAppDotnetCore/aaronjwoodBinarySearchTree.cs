using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public class aaronjwoodBinarySearchTree
  {
    class Node
    {
      public int value;
      public Node left;
      public Node right;
    }

    class Tree
    {
      public Node insert(Node root, int v)
      {
        if (root == null)
        {
          root = new Node();
          root.value = v;
        }
        else if (v < root.value)
        {
          root.left = insert(root.left, v);
        }
        else
        {
          root.right = insert(root.right, v);
        }

        return root;
      }

      public void traverse(Node root, Action<int> action)
      {
        if (root == null)
        {
          return;
        }

        traverse(root.left, action);
        action(root.value);
        traverse(root.right, action);
      }
    }


    public class BinarySearchTree
    {
      public void Print(int value)
      {
        Console.WriteLine(value);
      }

      public void Start()
      {
        Node root = null;
        Tree bst = new Tree();
        int SIZE = 10;
        int[] a = new int[SIZE];

        Console.WriteLine("Generating random array with {0} values...", SIZE);

        Random random = new Random();

        Stopwatch watch = Stopwatch.StartNew();

        for (int i = 0; i < SIZE; i++)
        {
          a[i] = random.Next(1000);
        }

        watch.Stop();

        Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
        Console.WriteLine();
        Console.WriteLine("Filling the tree with {0} nodes...", SIZE);

        watch = Stopwatch.StartNew();

        for (int i = 0; i < SIZE; i++)
        {
          root = bst.insert(root, a[i]);
        }

        watch.Stop();

        Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
        Console.WriteLine();
        Console.WriteLine("Traversing all {0} nodes in tree...", SIZE);

        watch = Stopwatch.StartNew();

        bst.traverse(root, Print);

        watch.Stop();

        Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
        Console.WriteLine();

        Console.ReadKey();
      }
    }
  }
}
