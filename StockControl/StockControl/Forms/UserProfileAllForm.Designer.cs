namespace StockControl.Forms
{
    partial class UserProfileAllForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.pbxEdit = new System.Windows.Forms.PictureBox();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxBack = new System.Windows.Forms.PictureBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.pbxDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(310, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(8, 8);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(83, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Pesquisar:";
            this.lblSearch.UseWaitCursor = true;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(97, 8);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.UseWaitCursor = true;
            // 
            // pbxEdit
            // 
            this.pbxEdit.Image = global::StockControl.Properties.Resources.editar2;
            this.pbxEdit.Location = new System.Drawing.Point(250, 236);
            this.pbxEdit.Name = "pbxEdit";
            this.pbxEdit.Size = new System.Drawing.Size(33, 33);
            this.pbxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEdit.TabIndex = 6;
            this.pbxEdit.TabStop = false;
            this.pbxEdit.UseWaitCursor = true;
            this.pbxEdit.Click += new System.EventHandler(this.pbxEdit_Click);
            // 
            // pbxAdd
            // 
            this.pbxAdd.Image = global::StockControl.Properties.Resources.mais_1;
            this.pbxAdd.Location = new System.Drawing.Point(211, 236);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(33, 33);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAdd.TabIndex = 5;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.UseWaitCursor = true;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            // 
            // pbxBack
            // 
            this.pbxBack.Image = global::StockControl.Properties.Resources.voltar;
            this.pbxBack.Location = new System.Drawing.Point(12, 236);
            this.pbxBack.Name = "pbxBack";
            this.pbxBack.Size = new System.Drawing.Size(33, 33);
            this.pbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBack.TabIndex = 4;
            this.pbxBack.TabStop = false;
            this.pbxBack.UseWaitCursor = true;
            this.pbxBack.Click += new System.EventHandler(this.pbxBack_Click_1);
            // 
            // pbxSearch
            // 
            this.pbxSearch.Image = global::StockControl.Properties.Resources.lupa;
            this.pbxSearch.Location = new System.Drawing.Point(203, 8);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(20, 20);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSearch.TabIndex = 3;
            this.pbxSearch.TabStop = false;
            this.pbxSearch.UseWaitCursor = true;
            this.pbxSearch.Click += new System.EventHandler(this.pbxSearch_Click);
            // 
            // pbxDelete
            // 
            this.pbxDelete.Image = global::StockControl.Properties.Resources.x;
            this.pbxDelete.Location = new System.Drawing.Point(289, 236);
            this.pbxDelete.Name = "pbxDelete";
            this.pbxDelete.Size = new System.Drawing.Size(33, 33);
            this.pbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDelete.TabIndex = 19;
            this.pbxDelete.TabStop = false;
            this.pbxDelete.Click += new System.EventHandler(this.pbxDelete_Click_1);
            // 
            // UserProfileAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 281);
            this.Controls.Add(this.pbxDelete);
            this.Controls.Add(this.pbxEdit);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.pbxBack);
            this.Controls.Add(this.pbxSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserProfileAllForm";
            this.Text = "Tipo de Usuário";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.PictureBox pbxBack;
        private System.Windows.Forms.PictureBox pbxAdd;
        private System.Windows.Forms.PictureBox pbxEdit;
        private System.Windows.Forms.PictureBox pbxDelete;
    }
}