using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace BLL
{
    public partial class AccessRoleAdapter
    {

        private static List<AccessRole> GetAccessRoleCollectionFromAccessRoleDAL(List<DAL.AccessRoleDetail> records)
        {
             List<AccessRole> items = new List<AccessRole>();
             foreach (DAL.AccessRoleDetail item in records)
                items.Add(GetAccessRoleFromAccessRoleDAL(item));
             return items;
        }

        private static AccessRole GetAccessRoleFromAccessRoleDAL(DAL.AccessRoleDetail record)
        {
             if (record != null)
                 return new AccessRole(
							record.AccessRoleID, 
							record.AccessKey, 
							record.AccessCaption);
             return null;
        }

        public static AccessRole GetAccessRoleById(int accessroleid)
        {
             AccessRole items;
             DAL.AccessRole u = new DAL.AccessRole();
             bool CanCloseConnection= DBHelper.DbHelper.OpenConnection();
             DAL.AccessRoleDetail recordSet = u.GetAccessRoleById(accessroleid);
             items = GetAccessRoleFromAccessRoleDAL(recordSet);
             if (CanCloseConnection)
	             DBHelper.DbHelper.CloseConnection();
             return items;
        }

        public virtual Int32 GetAccessRoleMaxID()
        {
             return GetAccessRoleMaxID_Static();
        }

        public static Int32 GetAccessRoleMaxID_Static()
        {
             DAL.AccessRole u = new DAL.AccessRole();
             return u.AccessRole_GetMaxId();
        }

        public static List<AccessRole> SelectAll()
        {
             List<AccessRole> items;
             DAL.AccessRole u = new DAL.AccessRole();
             bool CanCloseConnection= DBHelper.DbHelper.OpenConnection();
             List<DAL.AccessRoleDetail> recordSet = u.GetAllAccessRole();
             items = GetAccessRoleCollectionFromAccessRoleDAL(recordSet);
             if (CanCloseConnection)
	             DBHelper.DbHelper.CloseConnection();
             return items;
        }

        public static Int32 Insert(Int32 accessroleid, string accesskey, string accesscaption)
        {
             DAL.AccessRoleDetail accessroleDetail = new DAL.AccessRoleDetail(accessroleid, accesskey, accesscaption);
             DAL.AccessRole u = new DAL.AccessRole();
             return u.InsertAccessRole(accessroleDetail);
        }

        public static Boolean Update(Int32 accessroleid, string accesskey, string accesscaption)
        {
             DAL.AccessRoleDetail accessroleDetail = new DAL.AccessRoleDetail(accessroleid, accesskey, accesscaption);
             DAL.AccessRole u = new DAL.AccessRole();
             if (u.UpdateAccessRole(accessroleDetail) > 0)
                 return true;
             return false;
        }

        public static Boolean Delete(Int32 accessroleid)
        {
             DAL.AccessRole u = new DAL.AccessRole();
             if (u.DeleteAccessRole(accessroleid) > 0)
                 return true;
             return false;
        }

        public static List<AccessRole> Search(string Filter)
        {
             List<AccessRole> items;
             DAL.AccessRole u = new DAL.AccessRole();
             bool CanCloseConnection= DBHelper.DbHelper.OpenConnection();
             List<DAL.AccessRoleDetail> recordSet = u.Search(Filter);
             items = GetAccessRoleCollectionFromAccessRoleDAL(recordSet);
             if (CanCloseConnection)
	             DBHelper.DbHelper.CloseConnection();
             return items;
        }

    }
}
