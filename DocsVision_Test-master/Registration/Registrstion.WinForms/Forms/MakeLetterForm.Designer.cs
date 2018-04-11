namespace Registrstion.WinForms.Forms
{
    partial class MakeLetterForm
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
            this.addReceiversB = new System.Windows.Forms.Button();
            this.sendLetterB = new System.Windows.Forms.Button();
            this.fullContentLetterControl1 = new Registrstion.WinForms.Controlers.FullContentLetterControl();
            this.SuspendLayout();
            // 
            // addReceiversB
            // 
            this.addReceiversB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addReceiversB.Location = new System.Drawing.Point(570, 122);
            this.addReceiversB.Name = "addReceiversB";
            this.addReceiversB.Size = new System.Drawing.Size(87, 23);
            this.addReceiversB.TabIndex = 3;
            this.addReceiversB.Text = "Add";
            this.addReceiversB.UseVisualStyleBackColor = true;
            this.addReceiversB.Click += new System.EventHandler(this.AddReceiversB_Click);
            // 
            // sendLetterB
            // 
            this.sendLetterB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendLetterB.Location = new System.Drawing.Point(570, 446);
            this.sendLetterB.Name = "sendLetterB";
            this.sendLetterB.Size = new System.Drawing.Size(87, 27);
            this.sendLetterB.TabIndex = 5;
            this.sendLetterB.Text = "Send";
            this.sendLetterB.UseVisualStyleBackColor = true;
            this.sendLetterB.Click += new System.EventHandler(this.SendLetterB_Click);
            // 
            // fullContentLetterControl1
            // 
            this.fullContentLetterControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullContentLetterControl1.Location = new System.Drawing.Point(34, 12);
            this.fullContentLetterControl1.Name = "fullContentLetterControl1";
            this.fullContentLetterControl1.NameLetter = "";
            this.fullContentLetterControl1.NameSender = "";
            this.fullContentLetterControl1.Size = new System.Drawing.Size(698, 461);
            this.fullContentLetterControl1.TabIndex = 8;
            this.fullContentLetterControl1.TextLetter = "";
            // 
            // MakeLetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 522);
            this.Controls.Add(this.sendLetterB);
            this.Controls.Add(this.addReceiversB);
            this.Controls.Add(this.fullContentLetterControl1);
            this.Name = "MakeLetterForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeLetterForm";
            this.Load += new System.EventHandler(this.MakeLetterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addReceiversB;
        private System.Windows.Forms.Button sendLetterB;
        private Controlers.FullContentLetterControl fullContentLetterControl1;
    }
}