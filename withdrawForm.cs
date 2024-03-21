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
    public partial class withdrawForm : Form
    {
        public withdrawForm()
        {
            InitializeComponent();
        }

        private void withdrawForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backWithdraw_Click(object sender, EventArgs e)
        {
            homepageForm form = new homepageForm();
            this.Hide();
            form.ShowDialog();
        }

        private void withdrawConfirm_Click(object sender, EventArgs e)
        {
            homepageForm form = new homepageForm();
            this.Hide();
            form.ShowDialog();
        }

        private void withdraw_Click(object sender, EventArgs e)
        {

        }
    }
}
