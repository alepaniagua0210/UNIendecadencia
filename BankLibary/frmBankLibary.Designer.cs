namespace BankLibary
{
    partial class frmBankLibary
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAccount = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtBalance = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 51);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 105);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Primer nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 150);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 205);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Saldo";
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(131, 48);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(274, 23);
            txtAccount.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(131, 97);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(274, 23);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(131, 147);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(274, 23);
            txtLastName.TabIndex = 6;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(131, 202);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(274, 23);
            txtBalance.TabIndex = 7;
            // 
            // frmBankLibary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 324);
            Controls.Add(txtBalance);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtAccount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBankLibary";
            Text = "frmBankLibary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAccount;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtBalance;
    }
}