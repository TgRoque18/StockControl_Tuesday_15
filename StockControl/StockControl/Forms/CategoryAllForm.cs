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
    public partial class CategoryAllForm : Form
    {
        public CategoryAllForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeDetailsForm homeForm = new HomeDetailsForm();

            homeForm.Show();
            this.Hide();

        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm categoryForm = new CategoryDetailsForm();

            categoryForm.Show();
            this.Hide();
        }
    }
}
