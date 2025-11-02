namespace UIHelper
{
    partial class FrmDialog
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
            this.btnCancel = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu = new Telerik.WinControls.UI.RadMenu();
            this.btnOk = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "انصراف";
            this.btnCancel.AccessibleName = "انصراف";
            this.btnCancel.Image = global::UIHelper.Properties.Resources.Cancel;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "انصراف";
            // 
            // radMenu
            // 
            this.radMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnOk,
            this.btnCancel});
            this.radMenu.Location = new System.Drawing.Point(0, 0);
            this.radMenu.Name = "radMenu";
            this.radMenu.Size = new System.Drawing.Size(329, 28);
            this.radMenu.TabIndex = 1;
            this.radMenu.Text = "radMenu1";
            // 
            // btnOk
            // 
            this.btnOk.AccessibleDescription = "تایید";
            this.btnOk.AccessibleName = "تایید";
            this.btnOk.Image = global::UIHelper.Properties.Resources.Apply;
            this.btnOk.Name = "btnOk";
            this.btnOk.Text = "تایید";
            // 
            // FrmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 191);
            this.Controls.Add(this.radMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDialog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDialog";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Telerik.WinControls.UI.RadMenuItem btnOk;
        public Telerik.WinControls.UI.RadMenuItem btnCancel;
        public Telerik.WinControls.UI.RadMenu radMenu;
    }
}