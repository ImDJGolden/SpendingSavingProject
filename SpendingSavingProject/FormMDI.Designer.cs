namespace SpendingSavingProject
{
    partial class FormMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.overzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overzichtToolStripMenuItem,
            this.spendingToolStripMenuItem,
            this.savingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1504, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // overzichtToolStripMenuItem
            // 
            this.overzichtToolStripMenuItem.Name = "overzichtToolStripMenuItem";
            this.overzichtToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.overzichtToolStripMenuItem.Text = "Overzicht";
            // 
            // spendingToolStripMenuItem
            // 
            this.spendingToolStripMenuItem.Name = "spendingToolStripMenuItem";
            this.spendingToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.spendingToolStripMenuItem.Text = "Spending";
            // 
            // savingToolStripMenuItem
            // 
            this.savingToolStripMenuItem.Name = "savingToolStripMenuItem";
            this.savingToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.savingToolStripMenuItem.Text = "Saving";
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 736);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMDI";
            this.Text = "FormMDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem overzichtToolStripMenuItem;
        private ToolStripMenuItem spendingToolStripMenuItem;
        private ToolStripMenuItem savingToolStripMenuItem;
    }
}