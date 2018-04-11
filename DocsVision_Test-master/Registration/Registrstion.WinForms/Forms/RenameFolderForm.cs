﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registration.ClientInterface;
using System.ComponentModel.Design;
using Registration.Model;


namespace Registrstion.WinForms.Forms
{
    public partial class RenameFolderForm : Form
    {
        private IClientRequests _clientRequests;
        public RenameFolderForm()
        {
            InitializeComponent();
        }

        private IClientRequests ClientRequests
        {
            get { return _clientRequests; }
        }

        private void InitializeClientService()
        {
            _clientRequests = (IClientRequests)Program.GetServiceContainer().GetService(typeof(IClientRequests));
        }

        private void RenameFolderForm_Load(object sender, EventArgs e)
        {
            InitializeClientService();
            newNameTB.Text = Program.Folder.Name; 
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            Folder folder = Program.Folder;
            ClientRequests.UpdateFolder(folder.Id, newNameTB.Text);
            Close();
        }
    }
}