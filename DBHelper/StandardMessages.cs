using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBHelper
{
   public class StandardMessages
    {
        public static bool ConfirmDelete()
        {

            if (FMessegeBox.FarsiMessegeBox.Show("آیا برای حذف ردیف انتخاب شده اطمینان دارید؟", "",
                FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        public static bool ConfirmDelete(string ObjectPersianName)
        {

            if (FMessegeBox.FarsiMessegeBox.Show("آیا برای حذف "+ObjectPersianName+" انتخاب شده اطمینان دارید؟", "",
                FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        public static bool ConfirmMessage(string Message)
        {

            if (FMessegeBox.FarsiMessegeBox.Show(Message, "",
                FMessegeBox.FMessegeBoxButtons.YesNo, FMessegeBox.FMessegeBoxIcons.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        public static void ShowErrorMessage(string Message)
        {
            FMessegeBox.FarsiMessegeBox.Show(Message, "خطا", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Error);
        }
        public static void ShowMessage(string Message)
        {
            FMessegeBox.FarsiMessegeBox.Show(Message, "", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Information);
        }
        
    }
}
