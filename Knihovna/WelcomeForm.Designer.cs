namespace Knihovna
{
    partial class WelcomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelNazev;

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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelNazev = new System.Windows.Forms.Label();
            this.btnLoginForm = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.panelHeader.Controls.Add(this.labelNazev);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(450, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // labelNazev
            // 
            this.labelNazev.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelNazev.ForeColor = System.Drawing.Color.Snow;
            this.labelNazev.Location = new System.Drawing.Point(171, 6);
            this.labelNazev.Name = "labelNazev";
            this.labelNazev.Size = new System.Drawing.Size(141, 44);
            this.labelNazev.TabIndex = 0;
            this.labelNazev.Text = "Knihovna";
            // 
            // btnLoginForm
            // 
            this.btnLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoginForm.ForeColor = System.Drawing.Color.White;
            this.btnLoginForm.Location = new System.Drawing.Point(164, 59);
            this.btnLoginForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoginForm.Name = "btnLoginForm";
            this.btnLoginForm.Size = new System.Drawing.Size(112, 43);
            this.btnLoginForm.TabIndex = 4;
            this.btnLoginForm.Text = "Přihlášení";
            this.btnLoginForm.UseVisualStyleBackColor = true;
            this.btnLoginForm.Click += new System.EventHandler(this.btnLoginForm_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(164, 114);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(112, 43);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "O aplikaci";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(164, 169);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 43);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Zavřít";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 240);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnLoginForm);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "WelcomeForm";
            this.Text = "Knihovna";
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnLoginForm;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnClose;
    }
}
