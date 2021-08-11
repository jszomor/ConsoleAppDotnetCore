using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public class Node2
  {
    public Node2(int value)
    {
      Value = value;
    }

    public Node2 Left { get; set; }
    public Node2 Right { get; set; }
    public int Value { get; }
  }

  public class BinaryTree2
  {
    Node2 Root;
    public BinaryTree2(int[] values)
    {
      foreach (var value in values)
      {
        Insert(value);
        Root = InsertRec(Root, value);
      }
    }


    private void Insert(int value)
    {
      if (Root == null)
      {
        Root = new Node2(value);
      }
      else
      {
        Node2 currentNode = Root;
        while (currentNode != null)
        {
          if (currentNode.Value > value)
          {
            if (currentNode.Left == null)
            {
              currentNode.Left = new Node2(value);
              return;
            }
            else
            {
              currentNode = currentNode.Left;
            }
          }
          else if (currentNode.Value < value)
          {
            if (currentNode.Right == null)
            {
              currentNode.Right = new Node2(value);
              return;
            }
            else
            {
              currentNode = currentNode.Right;
            }
          }
          else
            return;
        }
      }
    }

    private Node2 InsertRec(Node2 root, int value)
    {
      if (root == null)
      {
        return new Node2(value);
      }

      if (value < root.Value)
      {
        root.Left = InsertRec(root.Left, value);
      }
      else
      {
        root.Right = InsertRec(root.Right, value);
      }

      return root;
    }

    public void InOrder(Action<int> action)
    {
      _inOrder(Root, action);
    }

    private void _inOrder(Node2 root, Action<int> print)
    {
      if (root == null) return;

      _inOrder(root.Left, print);
      print(root.Value);
      _inOrder(root.Right, print);
    }

    private void _inOrderBetween(Node2 root, Action<int> print)
    {
      if (root == null) return;

      _inOrderBetween(root.Left, print);

      if (root.Value >= 4 && root.Value <= 12)
      {
        print(root.Value);
      }

      _inOrderBetween(root.Right, print);
    }

    public void SearchKey(int key)
    {
      int searchedKey = searchKeyRec(Root, key).Value;
      Console.WriteLine(searchedKey);
    }

    private Node2 searchKeyRec(Node2 root, int key)
    {
      if (root == null || root.Value == key) return root;

      if (root.Value > key)
        return searchKeyRec(root.Left, key);

      return searchKeyRec(root.Right, key);
    }



    public void Print(int value)
    {
      Console.WriteLine(value);
    }
  }
}
