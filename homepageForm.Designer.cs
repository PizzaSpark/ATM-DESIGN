namespace smuATMsean
{
    partial class homepageForm
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
            this.withdrawRedirect = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.current = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depositRedirect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.withdrawRedirect);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.current);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.account);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.depositRedirect);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(150, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 600);
            this.panel1.TabIndex = 2;
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
            this.withdrawRedirect.Click += new System.EventHandler(this.withdrawRedirect_Click);
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
            this.logout.Click += new System.EventHandler(this.logout_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Account No";
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
            this.depositRedirect.Click += new System.EventHandler(this.depositRedirect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME!";
            // 
            // homepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(154)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.panel1);
            this.Name = "homepageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.homepageForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button depositRedirect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label current;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button withdrawRedirect;
    }
}