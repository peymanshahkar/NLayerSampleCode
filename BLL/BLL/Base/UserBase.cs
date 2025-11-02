using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace BLL
{
    public class UserBase : DAL.UserDetail,INotifyPropertyChanged
    {

        public UserBase (Int32 userid, string username, string password, string name, string family, DateTime? lastlogin)
        {
			UserID = userid;
			Username = username;
			Password = password;
			Name = name;
			Family = family;
			LastLogin = lastlogin;
        }

        public UserBase ()
        {
        }

        public virtual Int32 Insert()
        {
             return UserAdapter.Insert(UserID, Username, Password, Name, Family, LastLogin);
        }

        public virtual Boolean Update()
        {
             if (UserAdapter.Update(UserID, Username, Password, Name, Family, LastLogin))
                  return true;
             return false;
        }

        public virtual Boolean Delete()
        {
             if (UserAdapter.Delete(UserID))
                 return true;
             return false;
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        public virtual void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
             PropertyChangedEventHandler handler = PropertyChanged;
             if (handler != null) handler(this, e);
        }

        public virtual void ValidateDelete()
        {
        }

        public virtual void ValidateInsertUpdate()
        {
              if (String.IsNullOrEmpty(Username))
                throw new Exception("مقداری برای Username وارد نشده است");
              if (String.IsNullOrEmpty(Password))
                throw new Exception("مقداری برای Password وارد نشده است");
              if (String.IsNullOrEmpty(Name))
                throw new Exception("مقداری برای Name وارد نشده است");
              if (String.IsNullOrEmpty(Family))
                throw new Exception("مقداری برای Family وارد نشده است");
        }

    }
}
