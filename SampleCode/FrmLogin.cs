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
using Microsoft.Win32;

namespace SampleCode
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserAdapter.Login(txtUserName.Text, txtPassword.Text))
                {
                   if(chkRemember.Checked)
                        WriteDataInRegistery();
                   else
                        DeleteDataInRegistery();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DBHelper.StandardMessages.ShowErrorMessage("نام کاربری یا رمز عبور اشتباه می باشد");
                }
            }
            catch(Exception ex)
            {
                DBHelper.StandardMessages.ShowErrorMessage(ex.Message);
            }
        }

        private void DeleteDataInRegistery()
        {
            if (IsHaveSubKey())
            {
                RegistryKey RegisteryKeyCreator = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SampleCode", true);
                try
                {
                    RegisteryKeyCreator.DeleteValue("DefaultUserName");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    RegisteryKeyCreator.Close();
                }
            }
           
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            Common.EnterToTab(e);
        }
        BindingSource UsersBindingSource;
        
        private void Bind()
        {
            UserS users = User.GetUserS();
            UsersBindingSource = new BindingSource();
            UsersBindingSource.DataSource = users;

            txtUserName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtUserName.AutoCompleteMode = AutoCompleteMode.Suggest;

            txtUserName.DataBindings.Add(new Binding("Text", UsersBindingSource, "Username",true));
            LblName.DataBindings.Add(new Binding("Text", UsersBindingSource, "Name", true));
            LblFamily.DataBindings.Add(new Binding("Text", UsersBindingSource, "Family", true));
            lblLastLogin.DataBindings.Add(new Binding("Text", UsersBindingSource, "LastLogin", true));

            AutoCompleteStringCollection Suggests = new AutoCompleteStringCollection();
            foreach (var u in users)
            {
                Suggests.Add(u.Username);
            }
            txtUserName.AutoCompleteCustomSource = Suggests;

        

        }
        private void ReadDataFromRegistery()
        {
            if (IsHaveSubKey())
            {
                RegistryKey RegisteryKeyReader = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SampleCode");
                try
                {
                    var value = RegisteryKeyReader.GetValue("DefaultUserName");
                    if (value != null)
                        txtUserName.Text = value.ToString();
                    else
                        UsersBindingSource.Position = -1;
                }
                catch (Exception ex)
                {
                    DBHelper.StandardMessages.ShowErrorMessage(ex.Message);
                }
                finally
                {
                    RegisteryKeyReader.Close();
                }

                UsersBindingSource.Position = txtUserName.AutoCompleteCustomSource.IndexOf(txtUserName.Text);

            }

        }
        private bool IsHaveSubKey()
        {
            bool result = false;
            try
            {
                string[] subkeys = Registry.CurrentUser.OpenSubKey("SOFTWARE").GetSubKeyNames();
                if (subkeys.Count() == 0)
                    result= false;

                if (subkeys.Where(s => s.Contains("SampleCode")).Count() == 0)
                    result= false;

                result= true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Registry.CurrentUser.Close();
            }
            return result;
        }
        private void WriteDataInRegistery()
        {
            
            if (!IsHaveSubKey())
            {
                RegistryKey RegisteryKeyCreator = Registry.CurrentUser.CreateSubKey("SOFTWARE\\SampleCode");
                try
                {
                    RegisteryKeyCreator.SetValue("DefaultUserName", txtUserName.Text, RegistryValueKind.String);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    RegisteryKeyCreator.Close();
                }



            }
            else
            {
                RegistryKey RegisteryKeyCreator = Registry.CurrentUser.OpenSubKey("SOFTWARE\\SampleCode",true);
                try
                {
                    RegisteryKeyCreator.SetValue("DefaultUserName", txtUserName.Text, RegistryValueKind.String);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    RegisteryKeyCreator.Close();
                }

            }

        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
             Bind();
            ReadDataFromRegistery();
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
           UsersBindingSource.Position= txtUserName.AutoCompleteCustomSource.IndexOf(txtUserName.Text);
           
        }
    }
}
