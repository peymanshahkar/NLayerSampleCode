using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public abstract class UserAccessRoleProvider : DataAccess
    {

      protected virtual List<UserAccessRoleDetail> GetUserAccessRoleCollectionFromReader(IDataReader reader)
      {
            List<UserAccessRoleDetail> items = new List<UserAccessRoleDetail>();
            while (reader.Read())
                items.Add(GetUserAccessRoleFromReader(reader));
            reader.Close();
            return items;
      }

      protected virtual UserAccessRoleDetail GetUserAccessRoleFromReader(IDataReader reader)
      {
            return new UserAccessRoleDetail(reader);
      }


      public abstract List<UserAccessRoleDetail> GetAllUserAccessRole();


      public abstract UserAccessRoleDetail GetUserAccessRoleById(Int32 UserAccessRoleID);


      public abstract Int32 InsertUserAccessRole(UserAccessRoleDetail useraccessrole);


      public abstract Int32 UpdateUserAccessRole(UserAccessRoleDetail useraccessrole);


      public abstract Int32 DeleteUserAccessRole(Int32 UserAccessRoleID);


      public abstract List<UserAccessRoleDetail> Search(string filter);


      public abstract Int32 UserAccessRole_GetMaxId();

    }
}
