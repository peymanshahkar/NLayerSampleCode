using System;
using System.Collections.Generic;

namespace BLL
{
    public class UserS: System.ComponentModel.BindingList<User>
    {

        List<User> RemovedUserS = new List<User>();

        public UserS()
        {
        }


        public void UpdateObjects()
        {
             try
             {
                  foreach (User item in this)
                  {
                      item.UpdateObject();
                  }
                  foreach (User item in RemovedUserS)
                  {
                      item.DeleteObject();
                  }
                  RemovedUserS.Clear();
             }
             catch (Exception ex)
             {
                  throw ex;
             }
        }


        public bool RemoveObject(User item)
        {
             try
             {
                  bool result = this.Remove(item);
                  RemovedUserS.Add(item);
                  return result;
             }
             catch (Exception ex)
             {
                  throw ex;
             }
        }


        public void AddObject(User item)
        {
             this.Add(item);
        }

    }
}
