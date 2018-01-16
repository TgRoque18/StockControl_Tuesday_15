using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl.Forms
{
    public partial class StockDetailsForm : Form
    {
        string name;
        bool active;
        int quantity;

        public StockDetailsForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            StockAllForm stockallForm = new StockAllForm();

            stockallForm.Show();
            this.Hide();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            GetData();
            CleanData();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            StockAllForm stockallForm = new StockAllForm();

            stockallForm.Show();
            this.Hide();
        }

        void GetData()
        {
            name = tbxName.Text;
            active = cbxActive.Checked;
            quantity = Int32.Parse(tbxQuantity.Text);
        }

        void CleanData()
        {
            tbxName.Text = "";
            cbxActive.Checked = false;
            tbxQuantity.Text = "";
        }

    }
}
