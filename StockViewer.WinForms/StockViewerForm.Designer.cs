namespace StockViewer.WinForms
{
    partial class StockViewerForm
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
            this.portfolioListView = new System.Windows.Forms.ListView();
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.debugLog = new System.Windows.Forms.RichTextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.fetchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portfolioListView
            // 
            this.portfolioListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Stock,
            this.Quantity,
            this.Price,
            this.Value});
            this.portfolioListView.Location = new System.Drawing.Point(12, 110);
            this.portfolioListView.Name = "portfolioListView";
            this.portfolioListView.Size = new System.Drawing.Size(244, 257);
            this.portfolioListView.TabIndex = 0;
            this.portfolioListView.TabStop = false;
            this.portfolioListView.UseCompatibleStateImageBehavior = false;
            this.portfolioListView.View = System.Windows.Forms.View.Details;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Value
            // 
            this.Value.Text = "Value";
            // 
            // debugLog
            // 
            this.debugLog.Location = new System.Drawing.Point(262, 110);
            this.debugLog.Name = "debugLog";
            this.debugLog.ReadOnly = true;
            this.debugLog.Size = new System.Drawing.Size(257, 257);
            this.debugLog.TabIndex = 0;
            this.debugLog.TabStop = false;
            this.debugLog.Text = "";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(13, 12);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 13);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "User";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 39);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(71, 5);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(100, 20);
            this.userTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(71, 32);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTextBox_KeyPress);
            // 
            // fetchButton
            // 
            this.fetchButton.Location = new System.Drawing.Point(15, 72);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new System.Drawing.Size(88, 23);
            this.fetchButton.TabIndex = 2;
            this.fetchButton.Text = "Fetch Stocks";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += new System.EventHandler(this.FetchStocks);
            // 
            // StockViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 376);
            this.Controls.Add(this.fetchButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.debugLog);
            this.Controls.Add(this.portfolioListView);
            this.MaximizeBox = false;
            this.Name = "StockViewerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView portfolioListView;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.RichTextBox debugLog;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button fetchButton;
    }
}

