namespace SampleCode
{
    partial class FrmMain
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
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.ProductRibbon = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.btnProduct = new Telerik.WinControls.UI.RadButtonElement();
            this.btnProductList = new Telerik.WinControls.UI.RadButtonElement();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentContainer1 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
           // this.office2010SilverTheme1 = new Telerik.WinControls.Themes.Office2010SilverTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1});
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            this.radRibbonBar1.Size = new System.Drawing.Size(873, 162);
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "FrmMain";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.AccessibleDescription = "کالا";
            this.ribbonTab1.AccessibleName = "کالا";
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.ProductRibbon});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "کالا";
            // 
            // ProductRibbon
            // 
            this.ProductRibbon.AccessibleDescription = "کالا";
            this.ProductRibbon.AccessibleName = "کالا";
            this.ProductRibbon.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.btnProduct,
            this.btnProductList});
            this.ProductRibbon.Name = "ProductRibbon";
            this.ProductRibbon.Text = "کالا";
            // 
            // btnProduct
            // 
            this.btnProduct.AccessibleDescription = "تعریف کالا";
            this.btnProduct.AccessibleName = "تعریف کالا";
            this.btnProduct.Image = global::SampleCode.Properties.Resources._4_12;
            this.btnProduct.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Text = "تعریف کالا";
            this.btnProduct.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.AccessibleDescription = "radButtonElement2";
            this.btnProductList.AccessibleName = "radButtonElement2";
            this.btnProductList.Image = global::SampleCode.Properties.Resources.custom_reports_icon_481;
            this.btnProductList.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Text = "لیست کالا";
            this.btnProductList.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // radDock1
            // 
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.Location = new System.Drawing.Point(0, 162);
            // 
            // documentContainer1
            // 
            this.documentContainer1.Name = "documentContainer1";
            // 
            // 
            // 
            this.documentContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.radDock1.MainDocumentContainer = this.documentContainer1;
            this.radDock1.Name = "radDock1";
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.Size = new System.Drawing.Size(873, 354);
            this.radDock1.TabIndex = 3;
            this.radDock1.TabStop = false;
            this.radDock1.Text = "radDock1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 516);
            this.Controls.Add(this.radDock1);
            this.Controls.Add(this.radRibbonBar1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup ProductRibbon;
        private Telerik.WinControls.UI.RadButtonElement btnProduct;
        private Telerik.WinControls.UI.RadButtonElement btnProductList;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer1;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
      //  private Telerik.WinControls.Themes.Office2010SilverTheme office2010SilverTheme1;
    }
}