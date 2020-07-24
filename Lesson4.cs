using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson4
{
    public partial class frmLesson4 : Form
    {
        private const double basePrice = 15000;
        private const double pwPrice = 500;
        private const double acPrice = 750;
        private const double chPrice = 1000;
        private const double discount = 0.03;

        public frmLesson4()
        {
            InitializeComponent();
        }

        private void btnCalPrice_Click(object sender, EventArgs e)
        {
            double carPrice = basePrice;
            string name;

            if (chkWindow.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("You must make a choice for Power Windows", "Missing Entry");
                return;
            }
            else if (chkWindow.CheckState == CheckState.Checked)
            {
                carPrice += pwPrice;
            }

            if (chkAir.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("You must make a choice for Air Conditioning", "Missing Entry");
                return;
            }
            else if (chkAir.CheckState == CheckState.Checked)
            {
                carPrice += acPrice;
            }

            if (chkChrome.CheckState == CheckState.Indeterminate)
            {
                MessageBox.Show("You must make a choice for Chrome option", "Missing Entry");
                return;
            }
            else if (chkChrome.CheckState == CheckState.Checked)
            {
                carPrice += chPrice;
            }

            if (radPersonal.Checked == false && radBusiness.Checked == false)
            {
                MessageBox.Show("You must select the account type", "Missing Entry");
                return;
            }
            else if (radBusiness.Checked == true)
            {
                carPrice = carPrice - carPrice * discount;
            }

            if (radBlue.Checked == false && radWhite.Checked == false)
            {
                MessageBox.Show("You must make a color selection", "Missing Entry");
                return;
            }

            name = txtName.Text;
            MessageBox.Show(String.Format("{0}: Your new car price is {1:C}", name, carPrice), // Displayed text
                    "Final Quote", // Title
                    MessageBoxButtons.OK, // Buttons
                    MessageBoxIcon.Information);    // Icon
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.SelectAll();
        }
    }
}
