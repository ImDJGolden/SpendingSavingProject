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
            this.menuOverzichtToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSpendingToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInsertSpendToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSavingToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOverzichtToolStrip,
            this.menuSpendingToolStrip,
            this.menuSavingToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1955, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOverzichtToolStrip
            // 
            this.menuOverzichtToolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuOverzichtToolStrip.Name = "menuOverzichtToolStrip";
            this.menuOverzichtToolStrip.Size = new System.Drawing.Size(131, 36);
            this.menuOverzichtToolStrip.Text = "Overzicht";
            // 
            // menuSpendingToolStrip
            // 
            this.menuSpendingToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInsertSpendToolStrip});
            this.menuSpendingToolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuSpendingToolStrip.Name = "menuSpendingToolStrip";
            this.menuSpendingToolStrip.Size = new System.Drawing.Size(132, 36);
            this.menuSpendingToolStrip.Text = "Spending";
            // 
            // menuInsertSpendToolStrip
            // 
            this.menuInsertSpendToolStrip.Name = "menuInsertSpendToolStrip";
            this.menuInsertSpendToolStrip.Size = new System.Drawing.Size(270, 40);
            this.menuInsertSpendToolStrip.Text = "Insert Spend";
            this.menuInsertSpendToolStrip.Click += new System.EventHandler(this.menuInsertSpendToolStrip_Click);
            // 
            // menuSavingToolStrip
            // 
            this.menuSavingToolStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuSavingToolStrip.Name = "menuSavingToolStrip";
            this.menuSavingToolStrip.Size = new System.Drawing.Size(101, 36);
            this.menuSavingToolStrip.Text = "Saving";
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1955, 942);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMDI";
            this.Text = "FormMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuOverzichtToolStrip;
        private ToolStripMenuItem menuSpendingToolStrip;
        private ToolStripMenuItem menuSavingToolStrip;
        private ToolStripMenuItem menuInsertSpendToolStrip;
    }
}