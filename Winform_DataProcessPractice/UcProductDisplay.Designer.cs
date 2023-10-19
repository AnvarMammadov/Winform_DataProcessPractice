namespace Winform_DataProcessPractice
{
    partial class UcProductDisplay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.lblName = new System.Windows.Forms.Label();
            this.panelName = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.panelDesc = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panelPrice = new Guna.UI2.WinForms.Guna2Panel();
            this.productPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelName.SuspendLayout();
            this.panelDesc.SuspendLayout();
            this.panelPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(586, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 38);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 4);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // panelName
            // 
            this.panelName.AutoSize = true;
            this.panelName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelName.Controls.Add(this.lblName);
            this.panelName.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelName.ForeColor = System.Drawing.Color.White;
            this.panelName.Location = new System.Drawing.Point(108, 21);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(83, 34);
            this.panelName.TabIndex = 4;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(15, 4);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(156, 30);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Description";
            // 
            // panelDesc
            // 
            this.panelDesc.AutoSize = true;
            this.panelDesc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDesc.Controls.Add(this.lblDesc);
            this.panelDesc.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelDesc.ForeColor = System.Drawing.Color.White;
            this.panelDesc.Location = new System.Drawing.Point(247, 21);
            this.panelDesc.Name = "panelDesc";
            this.panelDesc.Size = new System.Drawing.Size(175, 34);
            this.panelDesc.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 4);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(78, 30);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // panelPrice
            // 
            this.panelPrice.AutoSize = true;
            this.panelPrice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPrice.Controls.Add(this.lblPrice);
            this.panelPrice.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelPrice.ForeColor = System.Drawing.Color.White;
            this.panelPrice.Location = new System.Drawing.Point(436, 21);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(112, 34);
            this.panelPrice.TabIndex = 6;
            // 
            // productPicture
            // 
            this.productPicture.BackColor = System.Drawing.Color.Transparent;
            this.productPicture.FillColor = System.Drawing.Color.Transparent;
            this.productPicture.Image = global::Winform_DataProcessPractice.Properties.Resources.iphone_x;
            this.productPicture.ImageRotate = 0F;
            this.productPicture.Location = new System.Drawing.Point(15, 14);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(74, 51);
            this.productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPicture.TabIndex = 7;
            this.productPicture.TabStop = false;
            // 
            // UcProductDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.productPicture);
            this.Controls.Add(this.panelPrice);
            this.Controls.Add(this.panelDesc);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.btnUpdate);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UcProductDisplay";
            this.Size = new System.Drawing.Size(723, 80);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelDesc.ResumeLayout(false);
            this.panelDesc.PerformLayout();
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Panel panelName;
        private System.Windows.Forms.Label lblDesc;
        private Guna.UI2.WinForms.Guna2Panel panelDesc;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Panel panelPrice;
        private Guna.UI2.WinForms.Guna2PictureBox productPicture;
    }
}
