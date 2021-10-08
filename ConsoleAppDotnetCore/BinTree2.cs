using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotnetCore
{
  public class NodeBin
  {
    public NodeBin Left;

    public NodeBin Right;

    public int Value { get; set; }

    public NodeBin(int value)
    {
      Value = value;
    }
  }


  public class BinTree2
  {
    NodeBin NodeBin;

    public BinTree2(int[] values)
    {
      foreach (var value in values)
      {
        //Insert(value);

        NodeBin = InsertRec2(NodeBin, value);
      }
    }

    private void Insert(int value)
    {
      if (NodeBin == null)
      {
        NodeBin = new NodeBin(value);
      }
      else
      {
        NodeBin current = NodeBin;

        while (current != null)
        {
          if (current.Value > value)
          {
            if (current.Left == null)
            {
              current.Left = new NodeBin(value);
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
              current.Right = new NodeBin(value);
              return;
            }
            else
            {
              current = current.Right;
            }
          }
          else
          {
            return;
          }
        }
      }
    }


    NodeBin InsertRec2(NodeBin root, int value)
    {
      if(root == null)
      {
        return new NodeBin(value);
      }
      else
      {
        if(root.Value > value)
        {
          root.Left = InsertRec2(root.Left, value); 
        }
        else if (root.Value < value)
        {
          root.Right = InsertRec2(root.Right, value);
        }
      }

      return root;
    }


    public delegate void PrintValueDelegate(int value);

    public void InOrder()
    {
      InOrderRec(NodeBin, Print);
    }

    void Print(int value)
    {
      Console.WriteLine(value);
    }

    private void InOrderRec(NodeBin nodeBin, PrintValueDelegate printValue)
    {
      if (nodeBin == null)
      {
        return;
      }

      InOrderRec(nodeBin.Left, printValue);

      //if(nodeBin.Value == 4)
      printValue(nodeBin.Value);

      InOrderRec(nodeBin.Right, printValue);
    }
  }  
}
