using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDotnetCore
{

  public class Node
  {
    public int Value { get; set; }
    public Node Next { get; set; }
    public Node Previous { get; set; }

    public Node(int value)
    {
      Value = value;
    }
  }

  public class LinkedList
  {
    public Node Root { get; private set; }

    public LinkedList(int[] values)
    {
      foreach (var item in values)
      {
        this.Add(item);
      }

      this.Delete(1);
    }

    public void Add(int value)
    {
      if(Root == null)
      {
        Root = new Node(value);
      }
      else
      {
        Node current = Root;
        while (current.Next != null)
        {
          current = current.Next;
        }
        current.Next = new Node(value);
        current.Next.Previous = current;
      }
    }

    public void Delete(int value)
    {
      if (Root == null) return;

      if(Root.Value == value)
      {
        Root = Root.Next;
        return;
      }

      Node current = Root;

      while(current.Next != null)
      {
        if(current.Next.Value == value)
        {
          current.Next = current.Next.Next;
          return;
        }

        current = current.Next;
      }
    }
  }
}
