using System;
using System.Collections.Generic;

namespace BLL
{
    public class UserAccessRoleS: System.ComponentModel.BindingList<UserAccessRole>
    {

        List<UserAccessRole> RemovedUserAccessRoleS = new List<UserAccessRole>();

        public UserAccessRoleS()
        {
        }


        public void UpdateObjects()
        {
             try
             {
                  foreach (UserAccessRole item in this)
                  {
                      item.UpdateObject();
                  }
                  foreach (UserAccessRole item in RemovedUserAccessRoleS)
                  {
                      item.DeleteObject();
                  }
                  RemovedUserAccessRoleS.Clear();
             }
             catch (Exception ex)
             {
                  throw ex;
             }
        }


        public bool RemoveObject(UserAccessRole item)
        {
             try
             {
                  bool result = this.Remove(item);
                  RemovedUserAccessRoleS.Add(item);
                  return result;
             }
             catch (Exception ex)
             {
                  throw ex;
             }
        }


        public void AddObject(UserAccessRole item)
        {
             this.Add(item);
        }

    }
}
