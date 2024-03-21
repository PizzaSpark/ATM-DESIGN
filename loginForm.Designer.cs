namespace smuATMsean
{
    partial class loginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signUpRedirect = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.pinLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accountLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.withdrawRedirect = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.current = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.depositRedirect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signUpRedirect);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.pinLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.accountLogin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(150, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 600);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(45, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Incorrect Account No or Pin No";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Need an account?";
            // 
            // signUpRedirect
            // 
            this.signUpRedirect.BackColor = System.Drawing.Color.White;
            this.signUpRedirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpRedirect.Location = new System.Drawing.Point(285, 517);
            this.signUpRedirect.Name = "signUpRedirect";
            this.signUpRedirect.Size = new System.Drawing.Size(121, 39);
            this.signUpRedirect.TabIndex = 6;
            this.signUpRedirect.Text = "SIGN UP";
            this.signUpRedirect.UseVisualStyleBackColor = false;
            this.signUpRedirect.Click += new System.EventHandler(this.signUpRedirect_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(87)))), ((int)(((byte)(132)))));
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(48, 348);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(402, 56);
            this.login.TabIndex = 5;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // pinLogin
            // 
            this.pinLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinLogin.Location = new System.Drawing.Point(48, 278);
            this.pinLogin.Name = "pinLogin";
            this.pinLogin.Size = new System.Drawing.Size(402, 30);
            this.pinLogin.TabIndex = 4;
            this.pinLogin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pin No";
            // 
            // accountLogin
            // 
            this.accountLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLogin.Location = new System.Drawing.Point(48, 178);
            this.accountLogin.Name = "accountLogin";
            this.accountLogin.Size = new System.Drawing.Size(402, 30);
            this.accountLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.withdrawRedirect);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.current);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.account);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.depositRedirect);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(759, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 600);
            this.panel2.TabIndex = 3;
            // 
            // withdrawRedirect
            // 
            this.withdrawRedirect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(87)))), ((int)(((byte)(132)))));
            this.withdrawRedirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawRedirect.Location = new System.Drawing.Point(252, 508);
            this.withdrawRedirect.Name = "withdrawRedirect";
            this.withdrawRedirect.Size = new System.Drawing.Size(198, 56);
            this.withdrawRedirect.TabIndex = 15;
            this.withdrawRedirect.Text = "WITHDRAW";
            this.withdrawRedirect.UseVisualStyleBackColor = false;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(412, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(85, 34);
            this.logout.TabIndex = 7;
            this.logout.Text = "LOG OUT";
            this.logout.UseVisualStyleBackColor = false;
            // 
            // current
            // 
            this.current.BackColor = System.Drawing.Color.Transparent;
            this.current.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current.Location = new System.Drawing.Point(64, 369);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(386, 25);
            this.current.TabIndex = 11;
            this.current.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Current Balance";
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.Color.Transparent;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(64, 258);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(386, 25);
            this.account.TabIndex = 9;
            this.account.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Account No";
            // 
            // depositRedirect
            // 
            this.depositRedirect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(87)))), ((int)(((byte)(132)))));
            this.depositRedirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositRedirect.Location = new System.Drawing.Point(48, 508);
            this.depositRedirect.Name = "depositRedirect";
            this.depositRedirect.Size = new System.Drawing.Size(198, 56);
            this.depositRedirect.TabIndex = 5;
            this.depositRedirect.Text = "DEPOSIT";
            this.depositRedirect.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "User Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "WELCOME!";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(154)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1350, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loginForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signUpRedirect;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox pinLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button withdrawRedirect;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label current;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button depositRedirect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

