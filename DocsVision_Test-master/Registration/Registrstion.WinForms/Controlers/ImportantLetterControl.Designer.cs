namespace Registrstion.WinForms.Controlers
{
    partial class ImportantLetterControl
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
            this.nameReceiversTB = new System.Windows.Forms.TextBox();
            this.nameReceiversCB = new System.Windows.Forms.ComboBox();
            this.textLetterTB = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelReceivers = new System.Windows.Forms.Label();
            this.nameSenderTB = new System.Windows.Forms.TextBox();
            this.labelSender = new System.Windows.Forms.Label();
            this.dateLetterTB = new System.Windows.Forms.TextBox();
            this.nameLetterTB = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelImportanceDegree = new System.Windows.Forms.Label();
            this.addReceiversB = new System.Windows.Forms.Button();
            this.importanceDegreeControl1 = new Registrstion.WinForms.Controlers.ImportanceDegreeControl();
            this.SuspendLayout();
            // 
            // nameReceiversTB
            // 
            this.nameReceiversTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameReceiversTB.Location = new System.Drawing.Point(27, 127);
            this.nameReceiversTB.Name = "nameReceiversTB";
            this.nameReceiversTB.ReadOnly = true;
            this.nameReceiversTB.Size = new System.Drawing.Size(330, 20);
            this.nameReceiversTB.TabIndex = 35;
            // 
            // nameReceiversCB
            // 
            this.nameReceiversCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameReceiversCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameReceiversCB.FormattingEnabled = true;
            this.nameReceiversCB.Location = new System.Drawing.Point(27, 127);
            this.nameReceiversCB.Name = "nameReceiversCB";
            this.nameReceiversCB.Size = new System.Drawing.Size(330, 21);
            this.nameReceiversCB.TabIndex = 34;
            this.nameReceiversCB.Visible = false;
            // 
            // textLetterTB
            // 
            this.textLetterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textLetterTB.Location = new System.Drawing.Point(27, 212);
            this.textLetterTB.Multiline = true;
            this.textLetterTB.Name = "textLetterTB";
            this.textLetterTB.ReadOnly = true;
            this.textLetterTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLetterTB.Size = new System.Drawing.Size(330, 296);
            this.textLetterTB.TabIndex = 33;
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(24, 196);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 32;
            this.labelMessage.Text = "&Message";
            // 
            // labelReceivers
            // 
            this.labelReceivers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelReceivers.AutoSize = true;
            this.labelReceivers.Location = new System.Drawing.Point(24, 110);
            this.labelReceivers.Name = "labelReceivers";
            this.labelReceivers.Size = new System.Drawing.Size(55, 13);
            this.labelReceivers.TabIndex = 31;
            this.labelReceivers.Text = "&Receivers";
            // 
            // nameSenderTB
            // 
            this.nameSenderTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameSenderTB.Location = new System.Drawing.Point(27, 87);
            this.nameSenderTB.Name = "nameSenderTB";
            this.nameSenderTB.ReadOnly = true;
            this.nameSenderTB.Size = new System.Drawing.Size(330, 20);
            this.nameSenderTB.TabIndex = 30;
            // 
            // labelSender
            // 
            this.labelSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSender.AutoSize = true;
            this.labelSender.Location = new System.Drawing.Point(24, 71);
            this.labelSender.Name = "labelSender";
            this.labelSender.Size = new System.Drawing.Size(41, 13);
            this.labelSender.TabIndex = 29;
            this.labelSender.Text = "&Sender";
            // 
            // dateLetterTB
            // 
            this.dateLetterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLetterTB.BackColor = System.Drawing.SystemColors.Control;
            this.dateLetterTB.Location = new System.Drawing.Point(390, 48);
            this.dateLetterTB.Name = "dateLetterTB";
            this.dateLetterTB.ReadOnly = true;
            this.dateLetterTB.Size = new System.Drawing.Size(118, 20);
            this.dateLetterTB.TabIndex = 28;
            // 
            // nameLetterTB
            // 
            this.nameLetterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nameLetterTB.Location = new System.Drawing.Point(27, 48);
            this.nameLetterTB.Name = "nameLetterTB";
            this.nameLetterTB.ReadOnly = true;
            this.nameLetterTB.Size = new System.Drawing.Size(330, 20);
            this.nameLetterTB.TabIndex = 27;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(387, 32);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 26;
            this.labelDate.Text = "&Date";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 25;
            this.labelName.Text = "&Name";
            // 
            // labelImportanceDegree
            // 
            this.labelImportanceDegree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelImportanceDegree.AutoSize = true;
            this.labelImportanceDegree.Location = new System.Drawing.Point(24, 149);
            this.labelImportanceDegree.Name = "labelImportanceDegree";
            this.labelImportanceDegree.Size = new System.Drawing.Size(109, 13);
            this.labelImportanceDegree.TabIndex = 23;
            this.labelImportanceDegree.Text = "Degree of importance";
            // 
            // addReceiversB
            // 
            this.addReceiversB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addReceiversB.Location = new System.Drawing.Point(390, 126);
            this.addReceiversB.Name = "addReceiversB";
            this.addReceiversB.Size = new System.Drawing.Size(87, 21);
            this.addReceiversB.TabIndex = 36;
            this.addReceiversB.Text = "Add";
            this.addReceiversB.UseVisualStyleBackColor = true;
            // 
            // importanceDegreeControl1
            // 
            this.importanceDegreeControl1.Location = new System.Drawing.Point(25, 165);
            this.importanceDegreeControl1.Name = "importanceDegreeControl1";
            this.importanceDegreeControl1.Size = new System.Drawing.Size(151, 28);
            this.importanceDegreeControl1.TabIndex = 38;
            // 
            // ImportantLetterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.importanceDegreeControl1);
            this.Controls.Add(this.addReceiversB);
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
            this.Controls.Add(this.labelImportanceDegree);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "ImportantLetterControl";
            this.Size = new System.Drawing.Size(555, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameReceiversTB;
        private System.Windows.Forms.ComboBox nameReceiversCB;
        private System.Windows.Forms.TextBox textLetterTB;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelReceivers;
        private System.Windows.Forms.TextBox nameSenderTB;
        private System.Windows.Forms.Label labelSender;
        private System.Windows.Forms.TextBox dateLetterTB;
        private System.Windows.Forms.TextBox nameLetterTB;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelImportanceDegree;
        private System.Windows.Forms.Button addReceiversB;
        private Controlers.ImportanceDegreeControl importanceDegreeControl1;
    }
}
