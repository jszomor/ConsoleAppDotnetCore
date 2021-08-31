using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public class NodeTree
  {
    public NodeTree Left { get; set; }
    public NodeTree Right { get; set; }
    public int _value { get; set; }

    public NodeTree(int value)
    {
      _value = value;
    }
  }
  public class BinTree
  {
    public BinTree(int[] values)
    {
      foreach (var value in values)
      {
        //Insert(value);
        Root = InserRec(Root, value);
      }
    }

    private NodeTree InserRec(NodeTree root, int value)
    {
      if(root == null)
      {
        return new NodeTree(value);
      }

      if(root._value > value)
      {
        root.Left = InserRec(root.Left, value);
      }

      else if (root._value < value)
      {
        root.Right = InserRec(root.Right, value);
      }

      return root;
    }

    public NodeTree Root { get; set; }

    private void Insert(int value)
    {
      if (Root == null)
      {
        Root = new NodeTree(value);
      }
      else
      {
        NodeTree CurrentNode = Root;

        while (CurrentNode != null)
        {
          if (CurrentNode._value > value)
          {
            if (CurrentNode.Left == null)
            {
              CurrentNode.Left = new NodeTree(value);
              return;
            }
            else
            {
              CurrentNode = CurrentNode.Left;
            }
          }
          else if (CurrentNode._value < value)
          {
            if (CurrentNode.Right == null)
            {
              CurrentNode.Right = new NodeTree(value);
              return;
            }
            else
            {
              CurrentNode = CurrentNode.Right;
            }
          }
          else
            return;
        }
      }
    }

    public void InOrderTraversal(Action<int> action)
    {
      _inOrderTraversal(Root, action);
    }

    private void _inOrderTraversal(NodeTree nodeTree, Action<int> action)
    {
      if(nodeTree == null)
      {
        return;
      }
      _inOrderTraversal(nodeTree.Left, action);
      action(nodeTree._value);
      _inOrderTraversal(nodeTree.Right, action);
    }

    public void PrintTree(int value)
    {
      Console.WriteLine(value);
    }
  }
}
