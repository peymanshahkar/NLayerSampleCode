using System;
using System.Data;

namespace DAL
{
    public class UserAccessRoleDetail
    {

        public UserAccessRoleDetail(Int32 useraccessroleid, Int32 userid, Int32 accessroleid, Boolean isaccess)
        {
			UserAccessRoleID = useraccessroleid;
			UserID = userid;
			AccessRoleID = accessroleid;
			IsAccess = isaccess;
        }

        public UserAccessRoleDetail(IDataReader reader)
        {
			UserAccessRoleID = (Int32)reader["UserAccessRoleID"];
			UserID = (Int32)reader["UserID"];
			AccessRoleID = (Int32)reader["AccessRoleID"];
			IsAccess = (Boolean)reader["IsAccess"];
        }

        public UserAccessRoleDetail()
        {
        }


        public virtual Int32 UserAccessRoleID { get; set; } 

        public virtual Int32 UserID { get; set; } 

        public virtual Int32 AccessRoleID { get; set; } 

        public virtual Boolean IsAccess { get; set; } 

    }
}
