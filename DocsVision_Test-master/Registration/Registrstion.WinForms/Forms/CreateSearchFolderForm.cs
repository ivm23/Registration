﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registrstion.WinForms.Forms
{
    public partial class CreateSearchFolderForm : Form
    {
        public CreateSearchFolderForm()
        {
            InitializeComponent();
        }

        public string SenderContains
        {
            set { senderContent.Text = value; }
            get { return senderContent.Text; }
        }
    }
}