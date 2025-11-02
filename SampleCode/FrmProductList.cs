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
    public partial class FrmProductList : UIHelper.FrmBaseList
    {
        public FrmProductList()
        {
            InitializeComponent();
            ApplyDenyPermission();
        }
        BindingSource ProductBindingSource;
        DataTable Dsproducts;
        private void SetData()
        {
            ProductBindingSource = new BindingSource();
            Dsproducts = DBHelper.DbHelper.ReadDataTable("exec Product_GetAll");   // ProductAdapter.SelectAll(); //
            ProductBindingSource.DataSource = Dsproducts;
            dgv.DataSource = ProductBindingSource;
            cmbStatus.SelectedIndex = 0;
        }
        private void ApplyDenyPermission()
        {
            if (!BLL.Permission.Product_Save)
            {
                btnNew.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
            if (!BLL.Permission.Product_Edit)
            {
                btnEdit.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
            if (!BLL.Permission.Product_Del)
            {
                btnDelete.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            }
           
        }
        private void FrmProductList_Load(object sender, EventArgs e)
        {
            SetData();
            
        }
        private void ListFilter()
        {
            if (cmbStatus.SelectedIndex == 0)
            {
                ProductBindingSource.Filter = string.Format("ProductCode like '%{0}%' AND ProductName like '%{1}%'",
                    txtProductCode.Text, txtProductName.Text);
            }
            else if (cmbStatus.SelectedIndex == 1)
            {
                ProductBindingSource.Filter = string.Format("ProductCode like '%{0}%' And ProductName like '%{1}%' And IsDisabled=0",
                    txtProductCode.Text, txtProductName.Text);
            } else if (cmbStatus.SelectedIndex == 2)
            {
                ProductBindingSource.Filter = string.Format("ProductCode like '%{0}%' AND ProductName like '%{1}%' And IsDisabled=1",
                    txtProductCode.Text, txtProductName.Text);
            }
            
            dgv.DataSource = ProductBindingSource;
            dgv.Refresh();
        }
        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            ListFilter();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            ListFilter();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListFilter();
        }

        private void txtProductCode_Enter(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("en-us");

            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetData();
        }

     

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((bool)dgv.Rows[e.RowIndex].Cells["ColIsDisabled"].Value)
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                
            }
            else
            {
                dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.GreenYellow;
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                    return;

                Product focusedProduct = ProductAdapter.GetProductById((int)dgv.CurrentRow.Cells[0].Value);
                if (focusedProduct != null)
                {

                    focusedProduct.DeleteObject();
                    SetData();
                }
            }
            catch (Exception ex)
            {
                DBHelper.StandardMessages.ShowErrorMessage(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmProduct frmproduct = new FrmProduct();
            frmproduct.ShowDialog();
            SetData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.SelectedRows.Count == 0)
                    return;

                Product focusedProduct = ProductAdapter.GetProductById((int)dgv.CurrentRow.Cells[0].Value);
                if (focusedProduct != null)
                {

                    FrmProduct frmproduct = new FrmProduct();
                    frmproduct.Set(focusedProduct);
                    frmproduct.ShowDialog();
                    SetData();
                }
            }
            catch (Exception ex)
            {
                DBHelper.StandardMessages.ShowErrorMessage(ex.Message);
            }
           
        }
    }
}
