using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public abstract class AccessRoleProvider : DataAccess
    {

      protected virtual List<AccessRoleDetail> GetAccessRoleCollectionFromReader(IDataReader reader)
      {
            List<AccessRoleDetail> items = new List<AccessRoleDetail>();
            while (reader.Read())
                items.Add(GetAccessRoleFromReader(reader));
            reader.Close();
            return items;
      }

      protected virtual AccessRoleDetail GetAccessRoleFromReader(IDataReader reader)
      {
            return new AccessRoleDetail(reader);
      }


      public abstract List<AccessRoleDetail> GetAllAccessRole();


      public abstract AccessRoleDetail GetAccessRoleById(Int32 AccessRoleID);


      public abstract Int32 InsertAccessRole(AccessRoleDetail accessrole);


      public abstract Int32 UpdateAccessRole(AccessRoleDetail accessrole);


      public abstract Int32 DeleteAccessRole(Int32 AccessRoleID);


      public abstract List<AccessRoleDetail> Search(string filter);


      public abstract Int32 AccessRole_GetMaxId();

    }
}
