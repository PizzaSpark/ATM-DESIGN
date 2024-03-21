namespace smuATMsean
{
    partial class depositForm
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
            this.backDeposit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amountDeposit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pinDeposit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deposit = new System.Windows.Forms.Button();
            this.newDeposit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.previousDeposit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.depositConfirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.depositConfirm);
            this.panel1.Controls.Add(this.newDeposit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.previousDeposit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.deposit);
            this.panel1.Controls.Add(this.amountDeposit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pinDeposit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.backDeposit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(150, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 600);
            this.panel1.TabIndex = 3;
            // 
            // backDeposit
            // 
            this.backDeposit.BackColor = System.Drawing.Color.White;
            this.backDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backDeposit.Location = new System.Drawing.Point(412, 3);
            this.backDeposit.Name = "backDeposit";
            this.backDeposit.Size = new System.Drawing.Size(85, 34);
            this.backDeposit.TabIndex = 7;
            this.backDeposit.Text = "BACK";
            this.backDeposit.UseVisualStyleBackColor = false;
            this.backDeposit.Click += new System.EventHandler(this.backDeposit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEPOSIT";
            // 
            // amountDeposit
            // 
            this.amountDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDeposit.Location = new System.Drawing.Point(52, 278);
            this.amountDeposit.Name = "amountDeposit";
            this.amountDeposit.Size = new System.Drawing.Size(398, 30);
            this.amountDeposit.TabIndex = 20;
            this.amountDeposit.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Amount to Deposit";
            // 
            // pinDeposit
            // 
            this.pinDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinDeposit.Location = new System.Drawing.Point(52, 178);
            this.pinDeposit.Name = "pinDeposit";
            this.pinDeposit.Size = new System.Drawing.Size(398, 30);
            this.pinDeposit.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pin No";
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(87)))), ((int)(((byte)(132)))));
            this.deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.Location = new System.Drawing.Point(48, 348);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(402, 56);
            this.deposit.TabIndex = 6;
            this.deposit.Text = "DEPOSIT";
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // newDeposit
            // 
            this.newDeposit.BackColor = System.Drawing.Color.Transparent;
            this.newDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDeposit.Location = new System.Drawing.Point(47, 533);
            this.newDeposit.Name = "newDeposit";
            this.newDeposit.Size = new System.Drawing.Size(278, 25);
            this.newDeposit.TabIndex = 24;
            this.newDeposit.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "New Balance";
            // 
            // previousDeposit
            // 
            this.previousDeposit.BackColor = System.Drawing.Color.Transparent;
            this.previousDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousDeposit.Location = new System.Drawing.Point(47, 462);
            this.previousDeposit.Name = "previousDeposit";
            this.previousDeposit.Size = new System.Drawing.Size(278, 25);
            this.previousDeposit.TabIndex = 22;
            this.previousDeposit.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Previous Balance";
            // 
            // depositConfirm
            // 
            this.depositConfirm.BackColor = System.Drawing.Color.White;
            this.depositConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositConfirm.Location = new System.Drawing.Point(329, 533);
            this.depositConfirm.Name = "depositConfirm";
            this.depositConfirm.Size = new System.Drawing.Size(121, 39);
            this.depositConfirm.TabIndex = 7;
            this.depositConfirm.Text = "CONFIRM";
            this.depositConfirm.UseVisualStyleBackColor = false;
            this.depositConfirm.Click += new System.EventHandler(this.depositConfirm_Click);
            // 
            // depositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(154)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.panel1);
            this.Name = "depositForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.depositForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pinDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Label newDeposit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label previousDeposit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button depositConfirm;
    }
}