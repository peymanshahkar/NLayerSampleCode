namespace UIHelper
{
    partial class FrmProgressBar
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
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.lblWait = new System.Windows.Forms.Label();
            this.picProgressbar = new System.Windows.Forms.PictureBox();
            this.pnlProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProgressbar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProgress
            // 
            this.pnlProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProgress.Controls.Add(this.lblWait);
            this.pnlProgress.Controls.Add(this.picProgressbar);
            this.pnlProgress.Location = new System.Drawing.Point(13, 13);
            this.pnlProgress.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(424, 100);
            this.pnlProgress.TabIndex = 5;
            // 
            // lblWait
            // 
            this.lblWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblWait.AutoSize = true;
            this.lblWait.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblWait.Location = new System.Drawing.Point(132, 20);
            this.lblWait.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(177, 17);
            this.lblWait.TabIndex = 29;
            this.lblWait.Text = "در حال انجام عملیات، لطفا صبر کنید";
            // 
            // picProgressbar
            // 
            this.picProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picProgressbar.Image = global::UIHelper.Properties.Resources.ProgressBar4;
            this.picProgressbar.Location = new System.Drawing.Point(177, 51);
            this.picProgressbar.Margin = new System.Windows.Forms.Padding(4);
            this.picProgressbar.Name = "picProgressbar";
            this.picProgressbar.Size = new System.Drawing.Size(88, 13);
            this.picProgressbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picProgressbar.TabIndex = 28;
            this.picProgressbar.TabStop = false;
            // 
            // FrmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(450, 126);
            this.Controls.Add(this.pnlProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProgressbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.PictureBox picProgressbar;
    }
}