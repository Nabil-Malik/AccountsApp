namespace AccountsApp
{
    partial class Form1
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
            this.grpAccountDetails = new System.Windows.Forms.GroupBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblDailyWithdrawLimit = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtDailyWithdrawlLimit = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.grpAccountType = new System.Windows.Forms.GroupBox();
            this.rbtChecking = new System.Windows.Forms.RadioButton();
            this.rbtVisa = new System.Windows.Forms.RadioButton();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.txtSearchAccount = new System.Windows.Forms.TextBox();
            this.lblSearchAccount = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpAccountDetails.SuspendLayout();
            this.grpAccountType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccountDetails
            // 
            this.grpAccountDetails.Controls.Add(this.btnCreateAccount);
            this.grpAccountDetails.Controls.Add(this.grpAccountType);
            this.grpAccountDetails.Controls.Add(this.txtClientName);
            this.grpAccountDetails.Controls.Add(this.txtBalance);
            this.grpAccountDetails.Controls.Add(this.txtInterestRate);
            this.grpAccountDetails.Controls.Add(this.txtDailyWithdrawlLimit);
            this.grpAccountDetails.Controls.Add(this.txtAccountNumber);
            this.grpAccountDetails.Controls.Add(this.lblBalance);
            this.grpAccountDetails.Controls.Add(this.lblDailyWithdrawLimit);
            this.grpAccountDetails.Controls.Add(this.lblInterestRate);
            this.grpAccountDetails.Controls.Add(this.lblClientName);
            this.grpAccountDetails.Controls.Add(this.lblAccountNumber);
            this.grpAccountDetails.Location = new System.Drawing.Point(12, 12);
            this.grpAccountDetails.Name = "grpAccountDetails";
            this.grpAccountDetails.Size = new System.Drawing.Size(496, 267);
            this.grpAccountDetails.TabIndex = 0;
            this.grpAccountDetails.TabStop = false;
            this.grpAccountDetails.Text = "Account Details";
            this.grpAccountDetails.Enter += new System.EventHandler(this.grpAccountDetails_Enter);
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(28, 31);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(121, 17);
            this.lblAccountNumber.TabIndex = 1;
            this.lblAccountNumber.Text = "Account Number: ";
            this.lblAccountNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(61, 67);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(88, 17);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "Client Name:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(52, 183);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(97, 17);
            this.lblInterestRate.TabIndex = 3;
            this.lblInterestRate.Text = "Interest Rate: ";
            // 
            // lblDailyWithdrawLimit
            // 
            this.lblDailyWithdrawLimit.AutoSize = true;
            this.lblDailyWithdrawLimit.Location = new System.Drawing.Point(11, 145);
            this.lblDailyWithdrawLimit.Name = "lblDailyWithdrawLimit";
            this.lblDailyWithdrawLimit.Size = new System.Drawing.Size(138, 17);
            this.lblDailyWithdrawLimit.TabIndex = 4;
            this.lblDailyWithdrawLimit.Text = "Daily Withdraw Limit:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(86, 105);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(63, 17);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "Balance:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(155, 31);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 22);
            this.txtAccountNumber.TabIndex = 6;
            // 
            // txtDailyWithdrawlLimit
            // 
            this.txtDailyWithdrawlLimit.Location = new System.Drawing.Point(155, 140);
            this.txtDailyWithdrawlLimit.Name = "txtDailyWithdrawlLimit";
            this.txtDailyWithdrawlLimit.Size = new System.Drawing.Size(100, 22);
            this.txtDailyWithdrawlLimit.TabIndex = 7;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(155, 180);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 22);
            this.txtInterestRate.TabIndex = 8;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(155, 105);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 22);
            this.txtBalance.TabIndex = 9;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(155, 67);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(160, 22);
            this.txtClientName.TabIndex = 10;
            // 
            // grpAccountType
            // 
            this.grpAccountType.Controls.Add(this.rbtVisa);
            this.grpAccountType.Controls.Add(this.rbtChecking);
            this.grpAccountType.Location = new System.Drawing.Point(331, 18);
            this.grpAccountType.Name = "grpAccountType";
            this.grpAccountType.Size = new System.Drawing.Size(149, 124);
            this.grpAccountType.TabIndex = 11;
            this.grpAccountType.TabStop = false;
            this.grpAccountType.Text = "Type of Account";
            // 
            // rbtChecking
            // 
            this.rbtChecking.AutoSize = true;
            this.rbtChecking.Checked = true;
            this.rbtChecking.Location = new System.Drawing.Point(23, 45);
            this.rbtChecking.Name = "rbtChecking";
            this.rbtChecking.Size = new System.Drawing.Size(87, 21);
            this.rbtChecking.TabIndex = 0;
            this.rbtChecking.TabStop = true;
            this.rbtChecking.Text = "Checking";
            this.rbtChecking.UseVisualStyleBackColor = true;
            this.rbtChecking.CheckedChanged += new System.EventHandler(this.rbtChecking_CheckedChanged);
            // 
            // rbtVisa
            // 
            this.rbtVisa.AutoSize = true;
            this.rbtVisa.Location = new System.Drawing.Point(23, 83);
            this.rbtVisa.Name = "rbtVisa";
            this.rbtVisa.Size = new System.Drawing.Size(56, 21);
            this.rbtVisa.TabIndex = 1;
            this.rbtVisa.Text = "Visa";
            this.rbtVisa.UseVisualStyleBackColor = true;
            this.rbtVisa.CheckedChanged += new System.EventHandler(this.rbtVisa_CheckedChanged);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(331, 206);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(149, 42);
            this.btnCreateAccount.TabIndex = 1;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Location = new System.Drawing.Point(167, 295);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Size = new System.Drawing.Size(100, 22);
            this.txtSearchAccount.TabIndex = 12;
            // 
            // lblSearchAccount
            // 
            this.lblSearchAccount.AutoSize = true;
            this.lblSearchAccount.Location = new System.Drawing.Point(40, 298);
            this.lblSearchAccount.Name = "lblSearchAccount";
            this.lblSearchAccount.Size = new System.Drawing.Size(108, 17);
            this.lblSearchAccount.TabIndex = 12;
            this.lblSearchAccount.Text = "Search Account";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(294, 294);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 329);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearchAccount);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.grpAccountDetails);
            this.Name = "Form1";
            this.Text = "Accounts";
            this.grpAccountDetails.ResumeLayout(false);
            this.grpAccountDetails.PerformLayout();
            this.grpAccountType.ResumeLayout(false);
            this.grpAccountType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccountDetails;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDailyWithdrawLimit;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.GroupBox grpAccountType;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDailyWithdrawlLimit;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.RadioButton rbtVisa;
        private System.Windows.Forms.RadioButton rbtChecking;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox txtSearchAccount;
        private System.Windows.Forms.Label lblSearchAccount;
        private System.Windows.Forms.Button btnSearch;
    }
}

