using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace BLL
{
    public partial class UserAccessRoleAdapter
    {

        private static List<UserAccessRole> GetUserAccessRoleCollectionFromUserAccessRoleDAL(List<DAL.UserAccessRoleDetail> records)
        {
             List<UserAccessRole> items = new List<UserAccessRole>();
             foreach (DAL.UserAccessRoleDetail item in records)
                items.Add(GetUserAccessRoleFromUserAccessRoleDAL(item));
             return items;
        }

        private static UserAccessRole GetUserAccessRoleFromUserAccessRoleDAL(DAL.UserAccessRoleDetail record)
        {
             if (record != null)
                 return new UserAccessRole(
							record.UserAccessRoleID, 
							record.UserID, 
							record.AccessRoleID, 
							record.IsAccess);
             return null;
        }

        public static UserAccessRole GetUserAccessRoleById(int useraccessroleid)
        {
             UserAccessRole items;
             DAL.UserAccessRole u = new DAL.UserAccessRole();
             bool CanCloseConnection= DBHelper.DbHelper.OpenConnection();
             DAL.UserAccessRoleDetail recordSet = u.GetUserAccessRoleById(useraccessroleid);
             items = GetUserAccessRoleFromUserAccessRoleDAL(recordSet);
             if (CanCloseConnection)
	             DBHelper.DbHelper.CloseConnection();
             return items;
        }

        public virtual Int32 GetUserAccessRoleMaxID()
        {
             return GetUserAccessRoleMaxID_Static();
        }

        public static Int32 GetUserAccessRoleMaxID_Static()
        {
             DAL.UserAccessRole u = new DAL.UserAccessRole();
             return u.UserAccessRole_GetMaxId();
        }

        public static List<UserAccessRole> SelectAll()
        {
             List<UserAccessRole> items;
             DAL.UserAccessRole u = new DAL.UserAccessRole();
             bool CanCloseConnection= DBHelper.DbHelper.OpenConnection();
             List<DAL.UserAccessRoleDetail> recordSet = u.GetAllUserAccessRole();
             items = GetUserAccessRoleCollectionFromUserAccessRoleDAL(recordSet);
             if (CanCloseConnection)
	             DBHelper.DbHelper.CloseConnection();
             return items;
        }

        public static Int32 Insert(Int32 useraccessroleid, Int32 userid, Int32 accessroleid, Boolean isaccess)
        {
             DAL.UserAccessRoleDetail useraccessroleDetail = new DAL.UserAccessRoleDetail(useraccessroleid, userid, accessroleid, isaccess);
             DAL.UserAccessRole u = new DAL.UserAccessRole();
             return u.InsertUserAccessRole(useraccessroleDetail);
        }

        public static Boolean Update(Int32 useraccessroleid, Int32 userid, Int32 accessroleid, Boolean isaccess)
        {
             DAL.UserAccessRoleDetail useraccessroleDetail = new DAL.UserAccessRoleDetail(useraccessroleid, userid, accessroleid, isaccess);
             DAL.UserAccessRole u = new DAL.UserAccessRole();
             if (u.UpdateUserAccessRole(useraccessroleDetail) > 0)
                 return true;
             return false;
        }

        public static Boolean Delete(Int32 useraccessroleid)
        {
             DAL.UserAccessRole u = new DAL.UserAccessRole();
             if (u.DeleteUserAccessRole(useraccessroleid) > 0)
                 return true;
             return false;
        }

        public static List<UserAccessRole> Search(string Filter)
        {
             List<UserAccessRole> items;
             DAL.UserAccessRole u = new DAL.UserAccessRole();
             bool CanCloseConnection= DBHelper.DbHelper.OpenConnection();
             List<DAL.UserAccessRoleDetail> recordSet = u.Search(Filter);
             items = GetUserAccessRoleCollectionFromUserAccessRoleDAL(recordSet);
             if (CanCloseConnection)
	             DBHelper.DbHelper.CloseConnection();
             return items;
        }

    }
}
