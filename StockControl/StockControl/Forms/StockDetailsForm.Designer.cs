namespace StockControl.Forms
{
    partial class StockDetailsForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            this.pbxSave = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 73);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(27, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Qtd:";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Location = new System.Drawing.Point(12, 109);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(34, 13);
            this.lblActive.TabIndex = 2;
            this.lblActive.Text = "Ativo:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(63, 39);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 3;
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.Location = new System.Drawing.Point(63, 108);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(15, 14);
            this.cbxActive.TabIndex = 5;
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(63, 73);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(100, 20);
            this.numericQuantity.TabIndex = 6;
            // 
            // pbxDelete
            // 
            this.pbxDelete.Image = global::StockControl.Properties.Resources.deletar;
            this.pbxDelete.Location = new System.Drawing.Point(239, 218);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(33, 32);
            this.pbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDelete.TabIndex = 14;
            this.pbxDelete.TabStop = false;
            // 
            // pbxSave
            // 
            this.pbxSave.Image = global::StockControl.Properties.Resources.salvar;
            this.pbxSave.Location = new System.Drawing.Point(200, 218);
            this.pbxSave.Name = "pbxSave";
            this.pbxSave.Size = new System.Drawing.Size(33, 32);
            this.pbxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSave.TabIndex = 13;
            this.pbxSave.TabStop = false;
            // 
            // pbxBack
            // 
            this.pbxBack.Image = global::StockControl.Properties.Resources.voltar;
            this.pbxBack.Location = new System.Drawing.Point(12, 218);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(33, 32);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBack.TabIndex = 12;
            this.pbxBack.TabStop = false;
            // 
            // StockDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxSave);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblName);
            this.Name = "StockDetailsForm";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxSave;
        private System.Windows.Forms.PictureBox pbxDelete;
    }
}