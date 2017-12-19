namespace StockControl.Forms
{
    partial class LoginDetailsForm
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
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pbxLogIn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxRecovery = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecovery)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxUser
            // 
            this.tbxUser.Location = new System.Drawing.Point(95, 136);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(100, 20);
            this.tbxUser.TabIndex = 1;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(95, 180);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(116, 120);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuário:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(121, 164);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Senha:";
            // 
            // pbxLogIn
            // 
            this.pbxLogIn.Image = global::StockControl.Properties.Resources.LogIn;
            this.pbxLogIn.Location = new System.Drawing.Point(95, 220);
            this.pbxLogIn.Name = "pbxLogIn";
            this.pbxLogIn.Size = new System.Drawing.Size(29, 30);
            this.pbxLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogIn.TabIndex = 5;
            this.pbxLogIn.TabStop = false;
            this.pbxLogIn.Click += new System.EventHandler(this.pbxLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StockControl.Properties.Resources.Imagem;
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbxRecovery
            // 
            this.pbxRecovery.Image = global::StockControl.Properties.Resources.recovey;
            this.pbxRecovery.Location = new System.Drawing.Point(166, 220);
            this.pbxRecovery.Name = "pbxRecovery";
            this.pbxRecovery.Size = new System.Drawing.Size(29, 30);
            this.pbxRecovery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRecovery.TabIndex = 6;
            this.pbxRecovery.TabStop = false;
            this.pbxRecovery.Click += new System.EventHandler(this.pbxRecovery_Click);
            // 
            // LoginDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pbxRecovery);
            this.Controls.Add(this.pbxLogIn);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginDetailsForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecovery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pbxLogIn;
        private System.Windows.Forms.PictureBox pbxRecovery;
    }
}