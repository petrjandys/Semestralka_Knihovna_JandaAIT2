namespace Knihovna
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.ListBox lstLoans;
        private System.Windows.Forms.Button btnLoanBook;
        private System.Windows.Forms.Button btnReturnBook;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.lstLoans = new System.Windows.Forms.ListBox();
            this.btnLoanBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 16;
            this.lstBooks.Location = new System.Drawing.Point(16, 15);
            this.lstBooks.Margin = new System.Windows.Forms.Padding(4);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(399, 244);
            this.lstBooks.TabIndex = 0;
            // 
            // lstLoans
            // 
            this.lstLoans.FormattingEnabled = true;
            this.lstLoans.ItemHeight = 16;
            this.lstLoans.Location = new System.Drawing.Point(16, 268);
            this.lstLoans.Margin = new System.Windows.Forms.Padding(4);
            this.lstLoans.Name = "lstLoans";
            this.lstLoans.Size = new System.Drawing.Size(399, 244);
            this.lstLoans.TabIndex = 1;
            // 
            // btnLoanBook
            // 
            this.btnLoanBook.Location = new System.Drawing.Point(424, 15);
            this.btnLoanBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoanBook.Name = "btnLoanBook";
            this.btnLoanBook.Size = new System.Drawing.Size(133, 28);
            this.btnLoanBook.TabIndex = 2;
            this.btnLoanBook.Text = "Půjčit knihu";
            this.btnLoanBook.UseVisualStyleBackColor = true;
            this.btnLoanBook.Click += new System.EventHandler(this.btnLoanBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(424, 269);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(133, 28);
            this.btnReturnBook.TabIndex = 3;
            this.btnReturnBook.Text = "Vrátit knihu";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 529);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnLoanBook);
            this.Controls.Add(this.lstLoans);
            this.Controls.Add(this.lstBooks);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.Text = "Knihovna";
            this.ResumeLayout(false);

        }
    }
}
