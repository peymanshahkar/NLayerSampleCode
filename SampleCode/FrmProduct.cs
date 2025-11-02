using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace SampleCode
{
    public partial class FrmProduct : UIHelper.FrmBase
    {
        public FrmProduct()
        {
            InitializeComponent();
            Bind();
            ApplyDenyPermission();
        }
        BindingSource ProductBindingSource;
        Product product=new Product();
        public void Set(Product product)
        {
            this.product = product;
            ProductBindingSource.DataSource = product;
        }
        private void Bind()
        {
            ProductBindingSource = new BindingSource();
            ProductBindingSource.DataSource = product;

            txtProductCode.DataBindings.Add(new Binding("Text", ProductBindingSource, "ProductCode", true, DataSourceUpdateMode.OnPropertyChanged));
            txtProductName.DataBindings.Add(new Binding("Text", ProductBindingSource, "ProductName", true, DataSourceUpdateMode.OnPropertyChanged));
            txtPrice.DataBindings.Add(new Binding("Text", ProductBindingSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            //IsDisabled
            chkIsDisabled.DataBindings.Add(new Binding("Checked", ProductBindingSource, "IsDisabled", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void ApplyDenyPermission()
        {
            if (!BLL.Permission.Product_Save)
            {
                btnNew.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
                
            }
            if (!BLL.Permission.Product_Edit)
            {
                btnSave.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
            if (!BLL.Permission.Product_Del)
            {
                btnDel.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
            if (!BLL.Permission.Product_Disabled)
            {
                chkIsDisabled.Enabled = false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                product.DeleteObject();
                
            }
            catch (Exception ex)
            {
                DBHelper.StandardMessages.ShowErrorMessage(ex.Message);
            }
            btnNew_Click(null, null);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            product = new Product();
            txtProductCode.Focus();
            ProductBindingSource.DataSource = product;
        }
        private void Save()
        {
            try
            {

                product.UpdateObject();

            }
            catch (Exception ex)
            {
                DBHelper.StandardMessages.ShowErrorMessage(ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            Save();
            btnNew_Click(null, null);
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                || (e.KeyChar >= 'آ' && e.KeyChar <= 'ی'))
                        e.Handled = true;
        }

        private void txtProductCode_Enter(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }
    }
}
