namespace StockControl.Forms
{
    partial class HomeDetailsForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbxLog = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.pbxUserProfile = new System.Windows.Forms.PictureBox();
            this.pbxProduct = new System.Windows.Forms.PictureBox();
            this.pbxCategory = new System.Windows.Forms.PictureBox();
            this.pbxStock = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(89, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Controle de Estoque";
            // 
            // pbxLog
            // 
            this.pbxLog.Image = global::StockControl.Properties.Resources.log3;
            this.pbxLog.Location = new System.Drawing.Point(191, 134);
            this.pbxLog.Name = "pbxLog";
            this.pbxLog.Size = new System.Drawing.Size(61, 54);
            this.pbxLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLog.TabIndex = 6;
            this.pbxLog.TabStop = false;
            this.pbxLog.Click += new System.EventHandler(this.pbxLog_Click);
            // 
            // pbxUser
            // 
            this.pbxUser.Image = global::StockControl.Properties.Resources.usuario1;
            this.pbxUser.Location = new System.Drawing.Point(110, 134);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(61, 54);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUser.TabIndex = 5;
            this.pbxUser.TabStop = false;
            this.pbxUser.Click += new System.EventHandler(this.pbxUser_Click);
            // 
            // pbxUserProfile
            // 
            this.pbxUserProfile.Image = global::StockControl.Properties.Resources.user_profile;
            this.pbxUserProfile.Location = new System.Drawing.Point(29, 134);
            this.pbxUserProfile.Name = "pbxUserProfile";
            this.pbxUserProfile.Size = new System.Drawing.Size(61, 54);
            this.pbxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUserProfile.TabIndex = 4;
            this.pbxUserProfile.TabStop = false;
            this.pbxUserProfile.Click += new System.EventHandler(this.pbxUserProfile_Click);
            // 
            // pbxProduct
            // 
            this.pbxProduct.Image = global::StockControl.Properties.Resources.produt_jpg;
            this.pbxProduct.Location = new System.Drawing.Point(191, 56);
            this.pbxProduct.Name = "pbxProduct";
            this.pbxProduct.Size = new System.Drawing.Size(61, 54);
            this.pbxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProduct.TabIndex = 3;
            this.pbxProduct.TabStop = false;
            // 
            // pbxCategory
            // 
            this.pbxCategory.Image = global::StockControl.Properties.Resources.categoria;
            this.pbxCategory.Location = new System.Drawing.Point(110, 56);
            this.pbxCategory.Name = "pbxCategory";
            this.pbxCategory.Size = new System.Drawing.Size(61, 54);
            this.pbxCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCategory.TabIndex = 2;
            this.pbxCategory.TabStop = false;
            this.pbxCategory.Click += new System.EventHandler(this.pbxCategory_Click);
            // 
            // pbxStock
            // 
            this.pbxStock.BackColor = System.Drawing.SystemColors.Control;
            this.pbxStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxStock.Image = global::StockControl.Properties.Resources.estoque2;
            this.pbxStock.Location = new System.Drawing.Point(29, 56);
            this.pbxStock.Name = "pbxStock";
            this.pbxStock.Size = new System.Drawing.Size(61, 54);
            this.pbxStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStock.TabIndex = 1;
            this.pbxStock.TabStop = false;
            this.pbxStock.Click += new System.EventHandler(this.pbxStock_Click);
            this.pbxStock.MouseEnter += new System.EventHandler(this.pbxStock_MouseEnter);
            this.pbxStock.MouseLeave += new System.EventHandler(this.pbxStock_MouseLeave);
            // 
            // pbxBack
            // 
            this.pbxBack.Image = global::StockControl.Properties.Resources.voltar;
            this.pbxBack.Location = new System.Drawing.Point(3, 228);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(33, 32);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBack.TabIndex = 0;
            this.pbxBack.TabStop = false;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click);
            // 
            // lblEstoque
            // 
            this.lblEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(29, 111);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(61, 19);
            this.lblEstoque.TabIndex = 8;
            this.lblEstoque.Text = "Estoque";
            this.lblEstoque.Visible = false;
            // 
            // HomeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxLog);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.pbxUserProfile);
            this.Controls.Add(this.pbxProduct);
            this.Controls.Add(this.pbxCategory);
            this.Controls.Add(this.pbxStock);
            this.Controls.Add(this.pbxBack);
            this.Name = "HomeDetailsForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxStock;
        private System.Windows.Forms.PictureBox pbxCategory;
        private System.Windows.Forms.PictureBox pbxProduct;
        private System.Windows.Forms.PictureBox pbxUserProfile;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.PictureBox pbxLog;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEstoque;
    }
}