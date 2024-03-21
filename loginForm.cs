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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

            signUpRedirect.TabStop = false;
            signUpRedirect.FlatStyle = FlatStyle.Flat;
            signUpRedirect.FlatAppearance.BorderSize = 0;
            signUpRedirect.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            homepageForm form = new homepageForm();
            this.Hide();
            form.ShowDialog();
        }

        private void signUpRedirect_Click(object sender, EventArgs e)
        {
            signupForm form = new signupForm();
            this.Hide();
            form.ShowDialog();
        }
    }
}
