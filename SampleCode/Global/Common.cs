
using System.Windows.Forms;

namespace SampleCode
{
    public class Common
    {
        public static void EnterToTab(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                System.Windows.Forms.SendKeys.Send("{TAB}");
            }

        }
    }
}
