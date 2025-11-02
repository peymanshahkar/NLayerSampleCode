using System;
using System.Data;

namespace DAL
{
    public class AccessRoleDetail
    {

        public AccessRoleDetail(Int32 accessroleid, string accesskey, string accesscaption)
        {
			AccessRoleID = accessroleid;
			AccessKey = accesskey;
			AccessCaption = accesscaption;
        }

        public AccessRoleDetail(IDataReader reader)
        {
			AccessRoleID = (Int32)reader["AccessRoleID"];
			AccessKey = (string)reader["AccessKey"];
			AccessCaption = (string)reader["AccessCaption"];
        }

        public AccessRoleDetail()
        {
        }


        public virtual Int32 AccessRoleID { get; set; } 

        public virtual string AccessKey { get; set; } 

        public virtual string AccessCaption { get; set; } 

    }
}
