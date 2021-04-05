using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public class TreeNode
  {
    public int Value { get; set; }
    public TreeNode(int value)
    {
      Value = value;
    }

    //public TreeNode Parent { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }
  }
  public class BinaryTree
  {
    public BinaryTree() { }
    public BinaryTree(int[] values)
    {
      foreach (var value in values)
      {
        this.Insert(value);
      }
    }

    public TreeNode Root { get; set; }

    private void Insert(int value) 
    {
      if (Root == null)
      {
        Root = new TreeNode(value);
      }
      else
      {
        TreeNode current = Root;

        while(current != null)
        {
          if (current.Value > value)
          {
            if (current.Left == null)
            {
              current.Left = new TreeNode(value);
              //current.Left.Parent = current;
              return;
            }
            else
            {
              current = current.Left;
            }
          }
          else if (current.Value < value)
          {
            if (current.Right == null)
            {
              current.Right = new TreeNode(value);
              //current.Right.Parent = current;
              return;
            }
            else
            {
              current = current.Right;
            }
          }
          else return;
        }
      }
    }

    public void InOrder(Action<int> action)
    {
      _inOrder(Root, action);
    }

    private void _inOrder(TreeNode root, Action<int> action)
    {
      if(root == null) { return; }

      _inOrder(root.Left, action);
      action(root.Value);
      _inOrder(root.Right, action);
    }

    public void Print(int value)
    {
      Console.WriteLine(value);
    }
  }
}
