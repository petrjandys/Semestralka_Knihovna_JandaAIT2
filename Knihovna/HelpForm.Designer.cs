namespace Knihovna
{
    partial class HelpForm
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
            this.label = new System.Windows.Forms.Label();
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
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 57);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 19);
            this.label.TabIndex = 1;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 240);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "HelpForm";
            this.Text = "Knihovna";
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label;
    }
}
