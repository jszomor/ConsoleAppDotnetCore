using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SoYouThinkYouCanLINQ
{
  public  class Presidents : IEnumerable<President>
  {

    #region old style enumerator
    //private class PresidentsIterator : IEnumerator<President>
    //{
    //  private readonly President[] source;
    //  private int currentIndex = -1; //-1 because compiler call moveNext first which increment the index

    //  public PresidentsIterator(President[] source)
    //  {
    //    this.source = source;
    //  }

    //  public President Current
    //  {
    //    get { return source[currentIndex];  }
    //  }

    //  object IEnumerator.Current
    //  {
    //    get { return source[currentIndex]; }
    //  }

    //  public void Dispose()
    //  {
    //  }

    //  public bool MoveNext()
    //  {
    //    return ++currentIndex <= source.Length - 1;
    //  }

    //  public void Reset()
    //  {
    //    currentIndex = -1;
    //  }
    //}

    #endregion

    private President[] presidents;

    public Presidents()
    {
      presidents = new President[]
      {
        new President{ Id = 44, FirstName = "Barack", LastName = "Obama", Year = 2009, IsAlive = true},
        new President{ Id = 43, FirstName = "George W.", LastName = "Bush", Year = 2001, IsAlive = true},
        new President{ Id = 42, FirstName = "William J.", LastName = "Clinton", Year = 1993, IsAlive = true},
        new President{ Id = 41, FirstName = "George H. W.", LastName = "Bush", Year = 1989, IsAlive = true},
        new President{ Id = 40, FirstName = "Ronald", LastName = "Reagen", Year = 1981, IsAlive = false},
        new President{ Id = 39, FirstName = "Jimmy", LastName = "Carter", Year = 1977, IsAlive = true},
        new President{ Id = 38, FirstName = "Gerald R.", LastName = "Ford", Year = 1974, IsAlive = false},
        new President{ Id = 37, FirstName = "Richard M.", LastName = "Nixson", Year = 1969, IsAlive = false},
        new President{ Id = 36, FirstName = "Lyndon B.", LastName = "Johnson", Year = 1963, IsAlive = false},
        new President{ Id = 35, FirstName = "Dwight D.", LastName = "Eisenhower", Year = 1953, IsAlive = false}
      };
    }

    private IEnumerator<President> GetEnumeratorInternal()
    {
      #region part of old style iterator
      // return new PresidentsIterator(presidents); 
      #endregion

      foreach (var item in presidents)
      {
        yield return item;
      }
    }

    public IEnumerator<President> GetEnumerator()
    {
      return GetEnumeratorInternal();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Manual implementation of where function from LINQ
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    public IEnumerable<President> Where (Func<President, bool> predicate)
    {
      foreach (var item in presidents)
      {
        if(predicate(item))
        {
          yield return item;
        }
      }
    }

    public bool InstedOfLINQSyntax(President president)
    {
      if (president.IsAlive)
        return true;

      else
        return false;
    }
  }
}
