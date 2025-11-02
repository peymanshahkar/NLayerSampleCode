using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace BLL
{
    public class UserAccessRoleBase : DAL.UserAccessRoleDetail,INotifyPropertyChanged
    {

        public UserAccessRoleBase (Int32 useraccessroleid, Int32 userid, Int32 accessroleid, Boolean isaccess)
        {
			UserAccessRoleID = useraccessroleid;
			UserID = userid;
			AccessRoleID = accessroleid;
			IsAccess = isaccess;
        }

        public UserAccessRoleBase ()
        {
        }

        public virtual Int32 Insert()
        {
             return UserAccessRoleAdapter.Insert(UserAccessRoleID, UserID, AccessRoleID, IsAccess);
        }

        public virtual Boolean Update()
        {
             if (UserAccessRoleAdapter.Update(UserAccessRoleID, UserID, AccessRoleID, IsAccess))
                  return true;
             return false;
        }

        public virtual Boolean Delete()
        {
             if (UserAccessRoleAdapter.Delete(UserAccessRoleID))
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
              if (UserID == 0)
                throw new Exception("مقداری برای UserID وارد نشده است");
              if (AccessRoleID == 0)
                throw new Exception("مقداری برای AccessRoleID وارد نشده است");
        }

    }
}
