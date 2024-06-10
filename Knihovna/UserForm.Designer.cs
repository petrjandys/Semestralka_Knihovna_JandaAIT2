namespace Knihovna
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.ListBox lstLoans;
        private System.Windows.Forms.Button btnLoanBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem odhlásitSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.odhlásitSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.změnitHesloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBooks
            // 
            this.lstBooks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 23;
            this.lstBooks.Location = new System.Drawing.Point(22, 58);
            this.lstBooks.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(404, 234);
            this.lstBooks.TabIndex = 0;
            // 
            // lstLoans
            // 
            this.lstLoans.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstLoans.FormattingEnabled = true;
            this.lstLoans.ItemHeight = 23;
            this.lstLoans.Location = new System.Drawing.Point(22, 312);
            this.lstLoans.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lstLoans.Name = "lstLoans";
            this.lstLoans.Size = new System.Drawing.Size(404, 234);
            this.lstLoans.TabIndex = 1;
            // 
            // btnLoanBook
            // 
            this.btnLoanBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnLoanBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoanBook.ForeColor = System.Drawing.Color.White;
            this.btnLoanBook.Location = new System.Drawing.Point(448, 142);
            this.btnLoanBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoanBook.Name = "btnLoanBook";
            this.btnLoanBook.Size = new System.Drawing.Size(164, 50);
            this.btnLoanBook.TabIndex = 2;
            this.btnLoanBook.Text = "Půjčit knihu";
            this.btnLoanBook.UseVisualStyleBackColor = false;
            this.btnLoanBook.Click += new System.EventHandler(this.btnLoanBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Location = new System.Drawing.Point(448, 413);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(164, 50);
            this.btnReturnBook.TabIndex = 3;
            this.btnReturnBook.Text = "Vrátit knihu";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odhlásitSeToolStripMenuItem,
            this.změnitHesloToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // odhlásitSeToolStripMenuItem
            // 
            this.odhlásitSeToolStripMenuItem.Name = "odhlásitSeToolStripMenuItem";
            this.odhlásitSeToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.odhlásitSeToolStripMenuItem.Text = "Odhlásit se";
            this.odhlásitSeToolStripMenuItem.Click += new System.EventHandler(this.zpetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // změnitHesloToolStripMenuItem
            // 
            this.změnitHesloToolStripMenuItem.Name = "změnitHesloToolStripMenuItem";
            this.změnitHesloToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.změnitHesloToolStripMenuItem.Text = "Změnit heslo";
            this.změnitHesloToolStripMenuItem.Click += new System.EventHandler(this.zmenitHesloClick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 576);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnLoanBook);
            this.Controls.Add(this.lstLoans);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripMenuItem změnitHesloToolStripMenuItem;
    }
}
