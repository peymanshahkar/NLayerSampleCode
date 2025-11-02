namespace UIHelper
{
    partial class FrmBaseList
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
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.btnNew = new Telerik.WinControls.UI.RadMenuItem();
            this.btnEdit = new Telerik.WinControls.UI.RadMenuItem();
            this.btnDelete = new Telerik.WinControls.UI.RadMenuItem();
            this.btnRefresh = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "جدید";
            this.radMenuItem1.AccessibleName = "جدید";
            this.radMenuItem1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "جدید";
            this.radMenuItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnDelete,
            this.btnRefresh});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(1147, 28);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = "جدید";
            this.btnNew.AccessibleName = "جدید";
            this.btnNew.Image = global::UIHelper.Properties.Resources.New;
            this.btnNew.Name = "btnNew";
            this.btnNew.Text = "جدید";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleDescription = "ویرایش";
            this.btnEdit.AccessibleName = "ویرایش";
            this.btnEdit.Image = global::UIHelper.Properties.Resources.Save_As_21;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "ویرایش";
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "حذف";
            this.btnDelete.AccessibleName = "حذف";
            this.btnDelete.Image = global::UIHelper.Properties.Resources.deletered_3_;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "حذف";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AccessibleDescription = "بازخوانی";
            this.btnRefresh.AccessibleName = "بازخوانی";
            this.btnRefresh.Image = global::UIHelper.Properties.Resources.RELOAD24;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Text = "بازخوانی";
            // 
            // FrmBaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 549);
            this.Controls.Add(this.radMenu1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmBaseList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmBaseList";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        public Telerik.WinControls.UI.RadMenuItem btnNew;
        public Telerik.WinControls.UI.RadMenuItem btnEdit;
        public Telerik.WinControls.UI.RadMenuItem btnDelete;
        public Telerik.WinControls.UI.RadMenuItem btnRefresh;
        public Telerik.WinControls.UI.RadMenu radMenu1;
    }
}