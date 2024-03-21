namespace smuATMsean
{
    partial class withdrawForm
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
            this.withdraw = new System.Windows.Forms.Button();
            this.amountWithdraw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pinWithdraw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backWithdraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.withdrawConfirm = new System.Windows.Forms.Button();
            this.newWithdraw = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.previousWithdraw = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.withdrawConfirm);
            this.panel1.Controls.Add(this.withdraw);
            this.panel1.Controls.Add(this.newWithdraw);
            this.panel1.Controls.Add(this.amountWithdraw);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.previousWithdraw);
            this.panel1.Controls.Add(this.pinWithdraw);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.backWithdraw);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(150, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 600);
            this.panel1.TabIndex = 4;
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(87)))), ((int)(((byte)(132)))));
            this.withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw.Location = new System.Drawing.Point(48, 348);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(402, 56);
            this.withdraw.TabIndex = 6;
            this.withdraw.Text = "WITHDRAW";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // amountWithdraw
            // 
            this.amountWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountWithdraw.Location = new System.Drawing.Point(52, 278);
            this.amountWithdraw.Name = "amountWithdraw";
            this.amountWithdraw.Size = new System.Drawing.Size(402, 30);
            this.amountWithdraw.TabIndex = 20;
            this.amountWithdraw.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Amount to Withdraw";
            // 
            // pinWithdraw
            // 
            this.pinWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinWithdraw.Location = new System.Drawing.Point(52, 178);
            this.pinWithdraw.Name = "pinWithdraw";
            this.pinWithdraw.Size = new System.Drawing.Size(402, 30);
            this.pinWithdraw.TabIndex = 18;
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
            // backWithdraw
            // 
            this.backWithdraw.BackColor = System.Drawing.Color.White;
            this.backWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backWithdraw.Location = new System.Drawing.Point(412, 3);
            this.backWithdraw.Name = "backWithdraw";
            this.backWithdraw.Size = new System.Drawing.Size(85, 34);
            this.backWithdraw.TabIndex = 7;
            this.backWithdraw.Text = "BACK";
            this.backWithdraw.UseVisualStyleBackColor = false;
            this.backWithdraw.Click += new System.EventHandler(this.backWithdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "WITHDRAW";
            // 
            // withdrawConfirm
            // 
            this.withdrawConfirm.BackColor = System.Drawing.Color.White;
            this.withdrawConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawConfirm.Location = new System.Drawing.Point(330, 533);
            this.withdrawConfirm.Name = "withdrawConfirm";
            this.withdrawConfirm.Size = new System.Drawing.Size(121, 39);
            this.withdrawConfirm.TabIndex = 25;
            this.withdrawConfirm.Text = "CONFIRM";
            this.withdrawConfirm.UseVisualStyleBackColor = false;
            this.withdrawConfirm.Click += new System.EventHandler(this.withdrawConfirm_Click);
            // 
            // newWithdraw
            // 
            this.newWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.newWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWithdraw.Location = new System.Drawing.Point(48, 533);
            this.newWithdraw.Name = "newWithdraw";
            this.newWithdraw.Size = new System.Drawing.Size(278, 25);
            this.newWithdraw.TabIndex = 29;
            this.newWithdraw.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 502);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 22);
            this.label7.TabIndex = 28;
            this.label7.Text = "New Balance";
            // 
            // previousWithdraw
            // 
            this.previousWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.previousWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousWithdraw.Location = new System.Drawing.Point(48, 462);
            this.previousWithdraw.Name = "previousWithdraw";
            this.previousWithdraw.Size = new System.Drawing.Size(278, 25);
            this.previousWithdraw.TabIndex = 27;
            this.previousWithdraw.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Previous Balance";
            // 
            // withdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(154)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.panel1);
            this.Name = "withdrawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.withdrawForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.TextBox amountWithdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pinWithdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backWithdraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button withdrawConfirm;
        private System.Windows.Forms.Label newWithdraw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label previousWithdraw;
        private System.Windows.Forms.Label label4;
    }
}