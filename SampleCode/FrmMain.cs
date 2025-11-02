using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCode
{
    public partial class FrmMain : Telerik.WinControls.UI.RadRibbonForm
    {
        Form form = null;
        FrmLogin frmlogin = new FrmLogin();
        public FrmMain()
        {
            InitializeComponent();
            
            if (frmlogin.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.radDock1.AutoDetectMdiChildren = true;
                this.documentContainer1.SendToBack();
                ribbonTab1.IsSelected = true;

                ApplyDenyPermission();
            }
           
        }
        private void ApplyDenyPermission()
        {

            if (!BLL.Permission.Product_View)
            {
                btnProductList.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
            if (!BLL.Permission.Product_Save)
            {
                btnProduct.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
            

        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            form= FormGetter.GetFormByName("Product");
            form.ShowDialog();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            form = FormGetter.GetFormByName("ProductList");
            form.FormBorderStyle = FormBorderStyle.None;
            form.MdiParent = this;
            form.Show();
        }

        private void radDock1_Click(object sender, EventArgs e)
        {

        }
    }
}
