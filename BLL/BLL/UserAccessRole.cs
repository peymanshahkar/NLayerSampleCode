using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BLL
{
    public class UserAccessRole : BLL.UserAccessRoleBase
    {

        public UserAccessRole (Int32 useraccessroleid, Int32 userid, Int32 accessroleid, Boolean isaccess) : base(useraccessroleid, userid, accessroleid, isaccess)
        {
			UserAccessRoleID = useraccessroleid;
			UserID = userid;
			AccessRoleID = accessroleid;
			IsAccess = isaccess;
        }

        public UserAccessRole(Int32 useraccessroleid, 
            Int32 userid,
            Int32 accessroleid, 
            Boolean isaccess,
            string accesscaption,
            string username,
            string name,
            string family,
            string accesskey) : base(useraccessroleid, userid, accessroleid, isaccess)
        {
            UserAccessRoleID = useraccessroleid;
            UserID = userid;
            AccessRoleID = accessroleid;
            IsAccess = isaccess;
            _AccessCaption = accesscaption;
            _UserName = username;
            _Name = name;
            _Family = family;
            _AccessKey = accesskey;
        }

        private string _AccessCaption;
        private string _UserName;
        private string _Name;
        private string _Family;
        private string _FullName;
        private string _AccessKey;

        public string UserName
        {
            get
            {
                if (string.IsNullOrEmpty(_UserName) && UserID != 0)
                {
                    _UserName = DBHelper.DbHelper.
                        ExecuteScalar("Select UserName From [User] Where UserID=" + UserID).ToString();
                }
                return _UserName;
            }

            set
            {
                _UserName = value;
            }
        }

        public string AccessCaption
        {
            get
            {
                if (string.IsNullOrEmpty(_AccessCaption) && AccessRoleID != 0)
                {
                    _AccessCaption = DBHelper.DbHelper.ExecuteScalar
                        ("Select AccessCaption From AccessRole Where AccessRoleID=" + AccessRoleID).ToString();
                }
                return _AccessCaption;
            }

            set
            {
                _AccessCaption = value;
            }
        }

        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(_FullName))
                {
                    if (UserID != 0)
                    {
                        _FullName = Name + " " + Family;
    
                    }
                }
                return _FullName;
            }

          
        }

        public string AccessKey
        {
            get
            {
                if (string.IsNullOrEmpty(_AccessKey) && AccessRoleID != 0)
                {
                    _AccessKey = DBHelper.DbHelper.ExecuteScalar
                        ("Select AccessKey From AccessRole Where AccessRoleID=" + AccessRoleID).ToString();
                }
                return _AccessKey;
            }

            set
            {
                _AccessKey = value;
            }
        }

        public string Name 
        {
            get
            {
                if (string.IsNullOrEmpty(_Name) && UserID != 0)
                {
                    _Name = DBHelper.DbHelper.ExecuteScalar
                        ("Select Name From [User] Where UserID=" + UserID).ToString();
                }
               

                return _Name;
            }
            
        }

        public string Family 
        {
            get
            {
                if (string.IsNullOrEmpty(_Family) && UserID != 0)
                {
                    _Family = DBHelper.DbHelper.ExecuteScalar
                        ("Select Family From [User] where UserID="+UserID).ToString();
                }
                return _Family;
            }
        }
        

        public UserAccessRole() : base()
        {
        }

        public static UserAccessRoleS GetUserAccessRoleSById(Int32 Id )
        {
             SqlDataReader reader;
             UserAccessRoleS useraccessroleS = new UserAccessRoleS();

             bool CanCloseConnection = DBHelper.DbHelper.OpenConnection();
             reader = DBHelper.DbHelper.ExecuteReader("exec UserAccessRole_Search 'UserAccessRoleID="+ Id +"'");
             UserAccessRole useraccessrole;
             while (reader.Read())
             {
                 useraccessrole = new UserAccessRole(
                        (Int32)reader["UserAccessRoleID"],
                        (Int32)reader["UserID"],
                        (Int32)reader["AccessRoleID"],
                        (Boolean)reader["IsAccess"]);

                useraccessroleS.AddObject(useraccessrole);
             }
              reader.Close();
              if (CanCloseConnection)
                  DBHelper.DbHelper.CloseConnection();
              return useraccessroleS;
        }
        public static UserAccessRoleS GetUserAccessRoleByUserID(int userId)
        {
            SqlDataReader reader;
            UserAccessRoleS userAccessRoleS = new UserAccessRoleS();
            DBHelper.DbHelper.OpenConnection();
            reader = DBHelper.DbHelper.ExecuteReader("exec USP_GetUserAccessRoleByUserID " + userId);
            UserAccessRole useraccessRole;
            while (reader.Read())
            {
                useraccessRole = new UserAccessRole
                    ((int)reader["UserAccessRoleID"], (int)reader["UserID"], (int)reader["AccessRoleID"], (bool)reader["IsAccess"]
                    , reader["AccessCaption"].ToString(), reader["UserName"].ToString(), reader["Name"].ToString()
                    , reader["Family"].ToString(), reader["AccessKey"].ToString());
                userAccessRoleS.Add(useraccessRole);
            }
            reader.Close();
            DBHelper.DbHelper.CloseConnection();

            return userAccessRoleS;
        }
        public void UpdateObject() {throw new NotImplementedException();}

        public bool DeleteObject(){throw new NotImplementedException();}

    }
}
