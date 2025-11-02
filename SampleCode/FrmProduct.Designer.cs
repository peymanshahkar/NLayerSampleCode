namespace SampleCode
{
    partial class FrmProduct
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsDisabled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.btnNew.Bounds = new System.Drawing.Rectangle(0, 0, 68, 28);
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.btnNew.RightToLeft = true;
            this.btnNew.ShowArrow = false;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseDefaultDisabledPaint = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.btnSave.Bounds = new System.Drawing.Rectangle(0, 0, 72, 28);
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.btnSave.RightToLeft = true;
            this.btnSave.ShowArrow = false;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseDefaultDisabledPaint = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.btnDel.Bounds = new System.Drawing.Rectangle(0, 0, 62, 28);
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.btnDel.RightToLeft = true;
            this.btnDel.ShowArrow = false;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseDefaultDisabledPaint = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.btnClose.Bounds = new System.Drawing.Rectangle(0, 0, 62, 28);
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.btnClose.RightToLeft = true;
            this.btnClose.ShowArrow = false;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseDefaultDisabledPaint = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.btnSaveNew.Bounds = new System.Drawing.Rectangle(0, 0, 105, 28);
            this.btnSaveNew.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnSaveNew.ForeColor = System.Drawing.Color.Black;
            this.btnSaveNew.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.btnSaveNew.RightToLeft = true;
            this.btnSaveNew.ShowArrow = false;
            this.btnSaveNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveNew.UseDefaultDisabledPaint = false;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.btnSaveClose.Bounds = new System.Drawing.Rectangle(0, 0, 107, 28);
            this.btnSaveClose.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnSaveClose.ForeColor = System.Drawing.Color.Black;
            this.btnSaveClose.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.btnSaveClose.RightToLeft = true;
            this.btnSaveClose.ShowArrow = false;
            this.btnSaveClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveClose.UseDefaultDisabledPaint = false;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductName.Location = new System.Drawing.Point(331, 64);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(121, 20);
            this.txtProductName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "نام کالا";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCode.Location = new System.Drawing.Point(90, 64);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(121, 20);
            this.txtProductCode.TabIndex = 7;
            this.txtProductCode.Enter += new System.EventHandler(this.txtProductCode_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "کد کالا";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(331, 100);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "قیمت";
            // 
            // chkIsDisabled
            // 
            this.chkIsDisabled.AutoSize = true;
            this.chkIsDisabled.Location = new System.Drawing.Point(148, 103);
            this.chkIsDisabled.Name = "chkIsDisabled";
            this.chkIsDisabled.Size = new System.Drawing.Size(63, 17);
            this.chkIsDisabled.TabIndex = 13;
            this.chkIsDisabled.Text = "غیرفعال";
            this.chkIsDisabled.UseVisualStyleBackColor = true;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 292);
            this.Controls.Add(this.chkIsDisabled);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduct";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "تعریف کالا";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtProductCode, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtProductName, 0);
            this.Controls.SetChildIndex(this.txtPrice, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.chkIsDisabled, 0);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsDisabled;
    }
}