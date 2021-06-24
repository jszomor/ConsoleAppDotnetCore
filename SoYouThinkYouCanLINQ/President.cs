using System;
using System.Collections.Generic;
using System.Text;

namespace SoYouThinkYouCanLINQ
{
  public sealed class President
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Year { get; set; }
    public string Email { get; set; }
    public bool IsAlive { get; set; }

    public override string ToString()
    {
      return string.Format($"Id:{Id}, Name:{FirstName} {LastName}, Year:{Year}, Email:{Email}, IsAlive:{IsAlive}");
    }
  }
}
