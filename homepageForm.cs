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
    public partial class homepageForm : Form
    {
        public homepageForm()
        {
            InitializeComponent();
        }

        private void homepageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            this.Hide();
            form.ShowDialog();
        }

        private void depositRedirect_Click(object sender, EventArgs e)
        {
            depositForm form = new depositForm();
            this.Hide();
            form.ShowDialog();
        }

        private void withdrawRedirect_Click(object sender, EventArgs e)
        {
            withdrawForm form = new withdrawForm();
            this.Hide();
            form.ShowDialog();
        }
    }
}
