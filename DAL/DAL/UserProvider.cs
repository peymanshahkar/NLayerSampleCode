using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public abstract class UserProvider : DataAccess
    {

      protected virtual List<UserDetail> GetUserCollectionFromReader(IDataReader reader)
      {
            List<UserDetail> items = new List<UserDetail>();
            while (reader.Read())
                items.Add(GetUserFromReader(reader));
            reader.Close();
            return items;
      }

      protected virtual UserDetail GetUserFromReader(IDataReader reader)
      {
            return new UserDetail(reader);
      }


      public abstract List<UserDetail> GetAllUser();


      public abstract UserDetail GetUserById(Int32 UserID);


      public abstract Int32 InsertUser(UserDetail user);


      public abstract Int32 UpdateUser(UserDetail user);


      public abstract Int32 DeleteUser(Int32 UserID);


      public abstract List<UserDetail> Search(string filter);


      public abstract Int32 User_GetMaxId();

    }
}
