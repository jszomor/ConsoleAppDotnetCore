using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractPattern
{
  public class SqlLiteDataAccess : DataAccess
  {
    public override string LoadData()
    {
      return "Load data from SqlLite database";
    }

    public override string SaveData()
    {
      return "Save data to sqlLite database";
    }
  }
}
