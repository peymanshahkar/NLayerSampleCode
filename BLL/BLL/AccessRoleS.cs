using System;
using System.Collections.Generic;

namespace BLL
{
    public class AccessRoleS: System.ComponentModel.BindingList<AccessRole>
    {

        List<AccessRole> RemovedAccessRoleS = new List<AccessRole>();

        public AccessRoleS()
        {
        }


        public void UpdateObjects()
        {
             try
             {
                  foreach (AccessRole item in this)
                  {
                      item.UpdateObject();
                  }
                  foreach (AccessRole item in RemovedAccessRoleS)
                  {
                      item.DeleteObject();
                  }
                  RemovedAccessRoleS.Clear();
             }
             catch (Exception ex)
             {
                  throw ex;
             }
        }


        public bool RemoveObject(AccessRole item)
        {
             try
             {
                  bool result = this.Remove(item);
                  RemovedAccessRoleS.Add(item);
                  return result;
             }
             catch (Exception ex)
             {
                  throw ex;
             }
        }


        public void AddObject(AccessRole item)
        {
             this.Add(item);
        }

    }
}
