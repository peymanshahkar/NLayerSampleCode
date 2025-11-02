namespace UIHelper
{
    partial class FrmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radMenu = new Telerik.WinControls.UI.RadMenu();
            this.btnNew = new Telerik.WinControls.UI.RadMenuItem();
            this.btnSave = new Telerik.WinControls.UI.RadMenuItem();
            this.btnSaveNew = new Telerik.WinControls.UI.RadMenuItem();
            this.btnSaveClose = new Telerik.WinControls.UI.RadMenuItem();
            this.btnDel = new Telerik.WinControls.UI.RadMenuItem();
            this.btnClose = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu
            // 
            this.radMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnNew,
            this.btnSave,
            this.btnSaveNew,
            this.btnSaveClose,
            this.btnDel,
            this.btnClose});
            this.radMenu.Location = new System.Drawing.Point(0, 0);
            this.radMenu.Margin = new System.Windows.Forms.Padding(4);
            this.radMenu.Name = "radMenu";
            this.radMenu.Size = new System.Drawing.Size(864, 28);
            this.radMenu.TabIndex = 0;
            this.radMenu.Text = "radMenu1";
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = "جدید";
            this.btnNew.AccessibleName = "جدید";
            this.btnNew.Image = global::UIHelper.Properties.Resources.New;
            this.btnNew.Name = "btnNew";
            this.btnNew.Text = "جدید";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = "ذخیره";
            this.btnSave.AccessibleName = "ذخیره";
            this.btnSave.Image = global::UIHelper.Properties.Resources.Save_As_21;
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "ذخیره";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.AccessibleDescription = "ذخیره و جدید";
            this.btnSaveNew.AccessibleName = "ذخیره و جدید";
            this.btnSaveNew.Image = global::UIHelper.Properties.Resources.SaveNew;
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Text = "ذخیره و جدید";
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.AccessibleDescription = "ذخیره و خروج";
            this.btnSaveClose.AccessibleName = "ذخیره و خروج";
            this.btnSaveClose.Image = global::UIHelper.Properties.Resources.SaveAndClose1;
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Text = "ذخیره و خروج";
            // 
            // btnDel
            // 
            this.btnDel.AccessibleDescription = "حذف";
            this.btnDel.AccessibleName = "حذف";
            this.btnDel.Image = global::UIHelper.Properties.Resources.deletered_3_;
            this.btnDel.Name = "btnDel";
            this.btnDel.Text = "حذف";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = "خروج";
            this.btnClose.AccessibleName = "خروج";
            this.btnClose.Image = global::UIHelper.Properties.Resources.close__1_;
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "خروج";
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 379);
            this.Controls.Add(this.radMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBase";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBase";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Telerik.WinControls.UI.RadMenuItem btnNew;
        public Telerik.WinControls.UI.RadMenu radMenu;
        public Telerik.WinControls.UI.RadMenuItem btnSave;
        public Telerik.WinControls.UI.RadMenuItem btnDel;
        public Telerik.WinControls.UI.RadMenuItem btnClose;
        public Telerik.WinControls.UI.RadMenuItem btnSaveNew;
        public Telerik.WinControls.UI.RadMenuItem btnSaveClose;
    }
}
