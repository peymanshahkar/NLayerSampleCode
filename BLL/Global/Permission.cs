using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace BLL
{
    public class Permission
    {
        public static bool CheckPermission(string AccessKey)
        {
            return GlobalValues.UserPermissionDictionery[AccessKey];
        }

        public static bool Product_View
        {
            get { return CheckPermission("Product_View"); }
        }
        
        public static bool Product_Edit
        {
            get { return CheckPermission("Product_Edit"); }
        }
        public static bool Product_Save
        {
            get { return CheckPermission("Product_Save"); }
        }
        public static bool Product_Del
        {
            get { return CheckPermission("Product_Del"); }
        }
        public static bool Product_Disabled
        {
            get { return CheckPermission("Product_Disabled"); }
        }
    }
}
