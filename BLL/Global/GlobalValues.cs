using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;
//using DAL;

namespace BLL
{
   public class GlobalValues
    {
        private static int _UserID;

        public static int UserID
        {
            get
            {
                return _UserID;
            }

            set
            {
                _UserID = value;
                _UserPermissionDictionery = null;
            }
        }

      

       

        private static string _UserName;

        public static string UserName
        {
            get
            {
                return _UserName;
            }

            set
            {
                _UserName = value;
            }
        }

       

        private static BLL.User _ThisUser;
        public static BLL.User ThisUser
        {
            get
            {
                if (_ThisUser == null)
                {
                    _ThisUser =UserAdapter.GetUserById(UserID);
                }
                return _ThisUser;
            }
        }

       

        private static Dictionary<string, bool> _UserPermissionDictionery;

        public static Dictionary<string, bool> UserPermissionDictionery
        {
            get
            {
                if (_UserPermissionDictionery == null)
                {
                    _UserPermissionDictionery = new Dictionary<string, bool>();

                    UserAccessRoleS accessRoles = UserAccessRole.GetUserAccessRoleByUserID(UserID);
                    foreach (UserAccessRole  item in accessRoles)
                    {
                        _UserPermissionDictionery.Add(item.AccessKey, item.IsAccess);
                    }
                }
                return _UserPermissionDictionery;
            }

        }


    }
}
