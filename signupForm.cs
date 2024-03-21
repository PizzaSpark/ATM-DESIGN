﻿using System;
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
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        private void signupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            this.Hide();
            form.ShowDialog();
        }

        private void loginRedirect_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            this.Hide();
            form.ShowDialog();
        }
    }
}
