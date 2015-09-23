namespace Lab3Form
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
            this.overdraftBox = new System.Windows.Forms.GroupBox();
            this.overdraftDebitButton = new System.Windows.Forms.Button();
            this.overdraftCreditButton = new System.Windows.Forms.Button();
            this.overdraftAmountTextBox = new System.Windows.Forms.TextBox();
            this.overdraftBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.savingsBox = new System.Windows.Forms.GroupBox();
            this.savingsDebitButton = new System.Windows.Forms.Button();
            this.savingsCreditButton = new System.Windows.Forms.Button();
            this.savingsAmountTextBox = new System.Windows.Forms.TextBox();
            this.savingsBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.overdraftBox.SuspendLayout();
            this.savingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // overdraftBox
            // 
            this.overdraftBox.Controls.Add(this.overdraftDebitButton);
            this.overdraftBox.Controls.Add(this.overdraftCreditButton);
            this.overdraftBox.Controls.Add(this.overdraftAmountTextBox);
            this.overdraftBox.Controls.Add(this.overdraftBalanceTextBox);
            this.overdraftBox.Controls.Add(this.label1);
            this.overdraftBox.Controls.Add(this.label2);
            this.overdraftBox.Location = new System.Drawing.Point(12, 12);
            this.overdraftBox.Name = "overdraftBox";
            this.overdraftBox.Size = new System.Drawing.Size(260, 114);
            this.overdraftBox.TabIndex = 0;
            this.overdraftBox.TabStop = false;
            this.overdraftBox.Text = "Overdraft";
            // 
            // overdraftDebitButton
            // 
            this.overdraftDebitButton.Location = new System.Drawing.Point(179, 57);
            this.overdraftDebitButton.Name = "overdraftDebitButton";
            this.overdraftDebitButton.Size = new System.Drawing.Size(75, 23);
            this.overdraftDebitButton.TabIndex = 8;
            this.overdraftDebitButton.Text = "Debit";
            this.overdraftDebitButton.UseVisualStyleBackColor = true;
            this.overdraftDebitButton.Click += new System.EventHandler(this.overdraftDebitButton_Click);
            // 
            // overdraftCreditButton
            // 
            this.overdraftCreditButton.Location = new System.Drawing.Point(179, 19);
            this.overdraftCreditButton.Name = "overdraftCreditButton";
            this.overdraftCreditButton.Size = new System.Drawing.Size(75, 23);
            this.overdraftCreditButton.TabIndex = 7;
            this.overdraftCreditButton.Text = " Credit";
            this.overdraftCreditButton.UseVisualStyleBackColor = true;
            this.overdraftCreditButton.Click += new System.EventHandler(this.overdraftCreditButton_Click);
            // 
            // overdraftAmountTextBox
            // 
            this.overdraftAmountTextBox.Location = new System.Drawing.Point(61, 77);
            this.overdraftAmountTextBox.Name = "overdraftAmountTextBox";
            this.overdraftAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.overdraftAmountTextBox.TabIndex = 6;
            // 
            // overdraftBalanceTextBox
            // 
            this.overdraftBalanceTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.overdraftBalanceTextBox.Location = new System.Drawing.Point(61, 38);
            this.overdraftBalanceTextBox.Name = "overdraftBalanceTextBox";
            this.overdraftBalanceTextBox.ReadOnly = true;
            this.overdraftBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.overdraftBalanceTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Balance:";
            // 
            // savingsBox
            // 
            this.savingsBox.Controls.Add(this.savingsDebitButton);
            this.savingsBox.Controls.Add(this.savingsCreditButton);
            this.savingsBox.Controls.Add(this.savingsAmountTextBox);
            this.savingsBox.Controls.Add(this.savingsBalanceTextBox);
            this.savingsBox.Controls.Add(this.label4);
            this.savingsBox.Controls.Add(this.label3);
            this.savingsBox.Location = new System.Drawing.Point(12, 132);
            this.savingsBox.Name = "savingsBox";
            this.savingsBox.Size = new System.Drawing.Size(260, 117);
            this.savingsBox.TabIndex = 1;
            this.savingsBox.TabStop = false;
            this.savingsBox.Text = "Savings";
            // 
            // savingsDebitButton
            // 
            this.savingsDebitButton.Location = new System.Drawing.Point(179, 56);
            this.savingsDebitButton.Name = "savingsDebitButton";
            this.savingsDebitButton.Size = new System.Drawing.Size(75, 23);
            this.savingsDebitButton.TabIndex = 9;
            this.savingsDebitButton.Text = "Debit";
            this.savingsDebitButton.UseVisualStyleBackColor = true;
            this.savingsDebitButton.Click += new System.EventHandler(this.savingsDebitButton_Click);
            // 
            // savingsCreditButton
            // 
            this.savingsCreditButton.Location = new System.Drawing.Point(179, 19);
            this.savingsCreditButton.Name = "savingsCreditButton";
            this.savingsCreditButton.Size = new System.Drawing.Size(75, 23);
            this.savingsCreditButton.TabIndex = 9;
            this.savingsCreditButton.Text = " Credit";
            this.savingsCreditButton.UseVisualStyleBackColor = true;
            this.savingsCreditButton.Click += new System.EventHandler(this.savingsCreditButton_Click);
            // 
            // savingsAmountTextBox
            // 
            this.savingsAmountTextBox.Location = new System.Drawing.Point(61, 78);
            this.savingsAmountTextBox.Name = "savingsAmountTextBox";
            this.savingsAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.savingsAmountTextBox.TabIndex = 8;
            // 
            // savingsBalanceTextBox
            // 
            this.savingsBalanceTextBox.Location = new System.Drawing.Point(61, 39);
            this.savingsBalanceTextBox.Name = "savingsBalanceTextBox";
            this.savingsBalanceTextBox.ReadOnly = true;
            this.savingsBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.savingsBalanceTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Balance:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.savingsBox);
            this.Controls.Add(this.overdraftBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.overdraftBox.ResumeLayout(false);
            this.overdraftBox.PerformLayout();
            this.savingsBox.ResumeLayout(false);
            this.savingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox overdraftBox;
        private System.Windows.Forms.GroupBox savingsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button overdraftDebitButton;
        private System.Windows.Forms.Button overdraftCreditButton;
        private System.Windows.Forms.Button savingsCreditButton;
        private System.Windows.Forms.Button savingsDebitButton;
        protected System.Windows.Forms.TextBox overdraftAmountTextBox;
        protected System.Windows.Forms.TextBox overdraftBalanceTextBox;
        protected System.Windows.Forms.TextBox savingsAmountTextBox;
        protected System.Windows.Forms.TextBox savingsBalanceTextBox;
    }
}

