using System;
using System.Data.Common;
using System.Data;

namespace DAL
{
    public abstract class DataAccess 
    {

      protected Int32 ExecuteNonQuery(DbCommand cmd)
      {
            return cmd.ExecuteNonQuery();
      }


      protected IDataReader ExecuteReader(DbCommand cmd)
      {
            return ExecuteReader(cmd, CommandBehavior.Default);
      }


      protected IDataReader ExecuteReader(DbCommand cmd, CommandBehavior behavior)
      {
            return cmd.ExecuteReader(behavior);
      }


      protected object ExecuteScalar(DbCommand cmd)
      {
            return cmd.ExecuteScalar();
      }

    }
}
