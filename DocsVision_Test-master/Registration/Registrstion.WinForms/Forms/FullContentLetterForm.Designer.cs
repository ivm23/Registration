﻿namespace Registration.WinForms.Forms
{
    partial class FullContentLetterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullContentLetterForm));
            this.fullContentLetterControl1 = new Controlers.FullContentLetterControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deleteLetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullContentLetterControl1
            // 
            this.fullContentLetterControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullContentLetterControl1.Location = new System.Drawing.Point(10, 24);
            this.fullContentLetterControl1.Name = "fullContentLetterControl1";
            this.fullContentLetterControl1.Size = new System.Drawing.Size(536, 424);
            this.fullContentLetterControl1.TabIndex = 0;
            this.fullContentLetterControl1.Load += new System.EventHandler(this.fullContentLetterControl1_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteLetterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deleteLetterToolStripMenuItem
            // 
            this.deleteLetterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteLetterToolStripMenuItem.Image")));
            this.deleteLetterToolStripMenuItem.Name = "deleteLetterToolStripMenuItem";
            this.deleteLetterToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.deleteLetterToolStripMenuItem.Text = "DeleteLetter";
            this.deleteLetterToolStripMenuItem.Click += new System.EventHandler(this.deleteLetterToolStripMenuItem_Click);
            // 
            // FullContentLetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 448);
            this.Controls.Add(this.fullContentLetterControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FullContentLetterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FullContentLetter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controlers.FullContentLetterControl fullContentLetterControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteLetterToolStripMenuItem;
    }
}