using StockControl.Class;
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
    public partial class CategoryDetailsForm : Form
    {
        string name;
        bool active;

        public CategoryDetailsForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeDetailsForm homeForm = new HomeDetailsForm();

            homeForm.Show();
            this.Hide();

        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            GetData();

            Category category = new Category(name, active);


        }

        void GetData()
        {
            name = tbxName.Text;
            active = cbxActive.Checked;
        }

        void CleanData()
        {
            tbxName.Text = "";
            cbxActive.Checked = false;
        }

       
    }
}
