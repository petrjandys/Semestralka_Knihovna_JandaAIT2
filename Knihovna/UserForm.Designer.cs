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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nastaveníÚčtuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.změnitHesloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zpětToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 16;
            this.lstBooks.Location = new System.Drawing.Point(7, 49);
            this.lstBooks.Margin = new System.Windows.Forms.Padding(4);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(399, 244);
            this.lstBooks.TabIndex = 0;
            // 
            // lstLoans
            // 
            this.lstLoans.FormattingEnabled = true;
            this.lstLoans.ItemHeight = 16;
            this.lstLoans.Location = new System.Drawing.Point(7, 302);
            this.lstLoans.Margin = new System.Windows.Forms.Padding(4);
            this.lstLoans.Name = "lstLoans";
            this.lstLoans.Size = new System.Drawing.Size(399, 244);
            this.lstLoans.TabIndex = 1;
            // 
            // btnLoanBook
            // 
            this.btnLoanBook.Location = new System.Drawing.Point(415, 49);
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
            this.btnReturnBook.Location = new System.Drawing.Point(415, 303);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(133, 28);
            this.btnReturnBook.TabIndex = 3;
            this.btnReturnBook.Text = "Vrátit knihu";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nastaveníÚčtuToolStripMenuItem,
            this.zpětToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nastaveníÚčtuToolStripMenuItem
            // 
            this.nastaveníÚčtuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.změnitHesloToolStripMenuItem});
            this.nastaveníÚčtuToolStripMenuItem.Name = "nastaveníÚčtuToolStripMenuItem";
            this.nastaveníÚčtuToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.nastaveníÚčtuToolStripMenuItem.Text = "Nastavení účtu";
            // 
            // změnitHesloToolStripMenuItem
            // 
            this.změnitHesloToolStripMenuItem.Name = "změnitHesloToolStripMenuItem";
            this.změnitHesloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.změnitHesloToolStripMenuItem.Text = "Změnit heslo";
            this.změnitHesloToolStripMenuItem.Click += new System.EventHandler(this.zmenitHeslo_click);
            // 
            // zpětToolStripMenuItem
            // 
            this.zpětToolStripMenuItem.Name = "zpětToolStripMenuItem";
            this.zpětToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.zpětToolStripMenuItem.Text = "Odhlásit se";
            this.zpětToolStripMenuItem.Click += new System.EventHandler(this.zpetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 596);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnLoanBook);
            this.Controls.Add(this.lstLoans);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.Text = "Knihovna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nastaveníÚčtuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem změnitHesloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zpětToolStripMenuItem;
    }
}
