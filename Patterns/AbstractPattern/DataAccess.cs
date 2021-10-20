using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractPattern
{
  public abstract class DataAccess
  {
    public DataAccess()
    {
    }

    public virtual string LoadData()
    {
      return "Load data from database.";
    }

    public abstract string SaveData();

    public virtual string DeleteData()
    {
      return "Delete data from database";
    }
  }
}
