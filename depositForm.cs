using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smuATMsean
{
    public partial class depositForm : Form
    {
        public depositForm()
        {
            InitializeComponent();
        }

        private void depositForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void deposit_Click(object sender, EventArgs e)
        {

        }

        private void backDeposit_Click(object sender, EventArgs e)
        {
            homepageForm form = new homepageForm();
            this.Hide();
            form.ShowDialog();
        }

        private void depositConfirm_Click(object sender, EventArgs e)
        {
            homepageForm form = new homepageForm();
            this.Hide();
            form.ShowDialog();
        }
    }
}
