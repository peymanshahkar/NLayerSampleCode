using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BLL
{
    public class AccessRole : BLL.AccessRoleBase
    {

        public AccessRole (Int32 accessroleid, string accesskey, string accesscaption) : base(accessroleid, accesskey, accesscaption)
        {
			AccessRoleID = accessroleid;
			AccessKey = accesskey;
			AccessCaption = accesscaption;
        }

        public AccessRole() : base()
        {
        }

        public static AccessRoleS GetAccessRoleSById(Int32 Id )
        {
             SqlDataReader reader;
             AccessRoleS accessroleS = new AccessRoleS();

             bool CanCloseConnection = DBHelper.DbHelper.OpenConnection();
             reader = DBHelper.DbHelper.ExecuteReader("exec AccessRole_Search 'AccessRoleID="+ Id +"'");
             AccessRole accessrole;
             while (reader.Read())
             {
                 accessrole = new AccessRole(
                        (Int32)reader["AccessRoleID"],
                        reader["AccessKey"].ToString(),
                        reader["AccessCaption"].ToString());

                accessroleS.AddObject(accessrole);
             }
              reader.Close();
              if (CanCloseConnection)
                  DBHelper.DbHelper.CloseConnection();
              return accessroleS;
        }

        public void UpdateObject() {throw new NotImplementedException();}

        public bool DeleteObject(){throw new NotImplementedException();}

    }
}
