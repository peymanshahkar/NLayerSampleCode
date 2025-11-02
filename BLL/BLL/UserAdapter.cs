using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace BLL
{
    public partial class UserAdapter
    {
        public static bool Login(string UserName, string Password)
        {
            List<User> appUserList = UserAdapter.Search(" LOWER(UserName)=N'" + UserName.ToLower() + "' And PassWord=N'" + Password + "'");
            if (appUserList.Count == 1)
            {
                GlobalValues.UserID = appUserList[0].UserID;
                GlobalValues.UserName = appUserList[0].Username;
                BLL.GlobalValues.ThisUser.LastLogin = DateTime.Now;
                BLL.GlobalValues.ThisUser.Update();
                return true;
            }
            return false;
        }
    }
}
