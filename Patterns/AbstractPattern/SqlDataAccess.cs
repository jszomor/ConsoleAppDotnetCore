using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractPattern
{
  public class SqlDataAccess : DataAccess
  {
    static SqlDataAccess()
    { 
    }

    public override string DeleteData()
    {
      return base.DeleteData();
    }

    public override string SaveData()
    {
      return "Save data to Sql database";
    }
  }
}
