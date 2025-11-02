using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace BLL
{
    public class AccessRoleBase : DAL.AccessRoleDetail,INotifyPropertyChanged
    {

        public AccessRoleBase (Int32 accessroleid, string accesskey, string accesscaption)
        {
			AccessRoleID = accessroleid;
			AccessKey = accesskey;
			AccessCaption = accesscaption;
        }

        public AccessRoleBase ()
        {
        }

        public virtual Int32 Insert()
        {
             return AccessRoleAdapter.Insert(AccessRoleID, AccessKey, AccessCaption);
        }

        public virtual Boolean Update()
        {
             if (AccessRoleAdapter.Update(AccessRoleID, AccessKey, AccessCaption))
                  return true;
             return false;
        }

        public virtual Boolean Delete()
        {
             if (AccessRoleAdapter.Delete(AccessRoleID))
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
              if (String.IsNullOrEmpty(AccessKey))
                throw new Exception("مقداری برای AccessKey وارد نشده است");
              if (String.IsNullOrEmpty(AccessCaption))
                throw new Exception("مقداری برای AccessCaption وارد نشده است");
        }

    }
}
