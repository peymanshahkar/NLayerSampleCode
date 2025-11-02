using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace BLL
{
    public partial class UserAdapter
    {

        private static List<User> GetUserCollectionFromUserDAL(List<DAL.UserDetail> records)
        {
             List<User> items = new List<User>();
             foreach (DAL.UserDetail item in records)
                items.Add(GetUserFromUserDAL(item));
             return items;
        }

        private static User GetUserFromUserDAL(DAL.UserDetail record)
        {
             if (record != null)
                 return new User(
							record.UserID, 
							record.Username, 
							record.Password, 
							record.Name, 
							record.Family, 
							record.LastLogin);
             return null;
        }

        public static User GetUserById(int userid)
        {
             User items;
             DAL.User u = new DAL.User();
             bool CanCloseConnection= DBHelper.DbHelper.OpenConnection();
             DAL.UserDetail recordSet = u.GetUserById(userid);
             items = GetUserFromUserDAL(recordSet);
             if (CanCloseConnection)
	             DBHelper.DbHelper.CloseConnection();
             return items;
        }

        public virtual Int32 GetUserMaxID()
        {
             return GetUserMaxID_Static();
        }

        public static Int32 GetUserMaxID_Static()
        {
             DAL.User u = new DAL.User();
             return u.User_GetMaxId();
        }

        public static List<User> SelectAll()
        {
             List<User> items;
             DAL.User u = new DAL.User();
             bool CanCloseConnection= DBHelper.DbHelper.OpenConnection();
             List<DAL.UserDetail> recordSet = u.GetAllUser();
             items = GetUserCollectionFromUserDAL(recordSet);
             if (CanCloseConnection)
	             DBHelper.DbHelper.CloseConnection();
             return items;
        }

        public static Int32 Insert(Int32 userid, string username, string password, string name, string family, DateTime? lastlogin)
        {
             DAL.UserDetail userDetail = new DAL.UserDetail(userid, username, password, name, family, lastlogin);
             DAL.User u = new DAL.User();
             return u.InsertUser(userDetail);
        }

        public static Boolean Update(Int32 userid, string username, string password, string name, string family, DateTime? lastlogin)
        {
             DAL.UserDetail userDetail = new DAL.UserDetail(userid, username, password, name, family, lastlogin);
             DAL.User u = new DAL.User();
             if (u.UpdateUser(userDetail) > 0)
                 return true;
             return false;
        }

        public static Boolean Delete(Int32 userid)
        {
             DAL.User u = new DAL.User();
             if (u.DeleteUser(userid) > 0)
                 return true;
             return false;
        }

        public static List<User> Search(string Filter)
        {
             List<User> items;
             DAL.User u = new DAL.User();
             bool CanCloseConnection= DBHelper.DbHelper.OpenConnection();
             List<DAL.UserDetail> recordSet = u.Search(Filter);
             items = GetUserCollectionFromUserDAL(recordSet);
             if (CanCloseConnection)
	             DBHelper.DbHelper.CloseConnection();
             return items;
        }

    }
}
