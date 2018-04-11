﻿namespace Registrstion.WinForms.Controlers
{
    partial class FullContentLetterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.nameLetterTB = new System.Windows.Forms.TextBox();
            this.dateLetterTB = new System.Windows.Forms.TextBox();
            this.labelSender = new System.Windows.Forms.Label();
            this.nameSenderTB = new System.Windows.Forms.TextBox();
            this.labelReceivers = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textLetterTB = new System.Windows.Forms.TextBox();
            this.nameReceiversCB = new System.Windows.Forms.ComboBox();
            this.nameReceiversTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "&Name";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(391, 16);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "&Date";
            // 
            // nameLetterTB
            // 
            this.nameLetterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLetterTB.Location = new System.Drawing.Point(19, 32);
            this.nameLetterTB.Name = "nameLetterTB";
            this.nameLetterTB.ReadOnly = true;
            this.nameLetterTB.Size = new System.Drawing.Size(330, 20);
            this.nameLetterTB.TabIndex = 2;
            // 
            // dateLetterTB
            // 
            this.dateLetterTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLetterTB.BackColor = System.Drawing.SystemColors.Control;
            this.dateLetterTB.Location = new System.Drawing.Point(394, 32);
            this.dateLetterTB.Name = "dateLetterTB";
            this.dateLetterTB.ReadOnly = true;
            this.dateLetterTB.Size = new System.Drawing.Size(118, 20);
            this.dateLetterTB.TabIndex = 3;
            // 
            // labelSender
            // 
            this.labelSender.AutoSize = true;
            this.labelSender.Location = new System.Drawing.Point(16, 55);
            this.labelSender.Name = "labelSender";
            this.labelSender.Size = new System.Drawing.Size(41, 13);
            this.labelSender.TabIndex = 4;
            this.labelSender.Text = "&Sender";
            // 
            // nameSenderTB
            // 
            this.nameSenderTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSenderTB.Location = new System.Drawing.Point(19, 71);
            this.nameSenderTB.Name = "nameSenderTB";
            this.nameSenderTB.ReadOnly = true;
            this.nameSenderTB.Size = new System.Drawing.Size(330, 20);
            this.nameSenderTB.TabIndex = 5;
            // 
            // labelReceivers
            // 
            this.labelReceivers.AutoSize = true;
            this.labelReceivers.Location = new System.Drawing.Point(16, 94);
            this.labelReceivers.Name = "labelReceivers";
            this.labelReceivers.Size = new System.Drawing.Size(55, 13);
            this.labelReceivers.TabIndex = 6;
            this.labelReceivers.Text = "&Receivers";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(16, 142);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 8;
            this.labelMessage.Text = "&Message";
            // 
            // textLetterTB
            // 
            this.textLetterTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLetterTB.Location = new System.Drawing.Point(19, 158);
            this.textLetterTB.Multiline = true;
            this.textLetterTB.Name = "textLetterTB";
            this.textLetterTB.ReadOnly = true;
            this.textLetterTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLetterTB.Size = new System.Drawing.Size(330, 296);
            this.textLetterTB.TabIndex = 9;
            // 
            // nameReceiversCB
            // 
            this.nameReceiversCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameReceiversCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameReceiversCB.FormattingEnabled = true;
            this.nameReceiversCB.Location = new System.Drawing.Point(19, 110);
            this.nameReceiversCB.Name = "nameReceiversCB";
            this.nameReceiversCB.Size = new System.Drawing.Size(330, 21);
            this.nameReceiversCB.TabIndex = 10;
            this.nameReceiversCB.Visible = false;
            // 
            // nameReceiversTB
            // 
            this.nameReceiversTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameReceiversTB.Location = new System.Drawing.Point(19, 111);
            this.nameReceiversTB.Name = "nameReceiversTB";
            this.nameReceiversTB.ReadOnly = true;
            this.nameReceiversTB.Size = new System.Drawing.Size(330, 20);
            this.nameReceiversTB.TabIndex = 11;
            // 
            // FullContentLetterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameReceiversTB);
            this.Controls.Add(this.nameReceiversCB);
            this.Controls.Add(this.textLetterTB);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelReceivers);
            this.Controls.Add(this.nameSenderTB);
            this.Controls.Add(this.labelSender);
            this.Controls.Add(this.dateLetterTB);
            this.Controls.Add(this.nameLetterTB);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.Name = "FullContentLetterControl";
            this.Size = new System.Drawing.Size(544, 457);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox nameLetterTB;
        private System.Windows.Forms.TextBox dateLetterTB;
        private System.Windows.Forms.Label labelSender;
        private System.Windows.Forms.TextBox nameSenderTB;
        private System.Windows.Forms.Label labelReceivers;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textLetterTB;
        private System.Windows.Forms.ComboBox nameReceiversCB;
        private System.Windows.Forms.TextBox nameReceiversTB;
    }
}