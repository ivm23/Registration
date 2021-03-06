﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Registration.ClientInterface;
using System.ComponentModel.Design;
using Registration.Logger;
using Registration.SerializationService;
using System.Drawing;

namespace Registration.WinForms.Forms
{
    internal partial class MakeLetterForm : Form
    {
        private IClientRequests _clientRequests;
        private Message.IMessageService _messageService;
        private List<string> nameAndLoginReceivers;
        private readonly IServiceProvider _serviceProvider;

        private List<Control> _baseControls;
        private Point _baseSizeHeight;

        public MakeLetterForm(IServiceProvider provider)
        {
            InitializeComponent();
            nameAndLoginReceivers = new List<string>();
            _serviceProvider = provider;
        }

        private IServiceProvider ServiceProvider => _serviceProvider;
        private IClientRequests ClientRequests
        {
            get { return _clientRequests; }
        }
        private Point BaseSizeHeight
        {
            get { return _baseSizeHeight; }
        }


        private Message.IMessageService MessageService
        {
            get { return _messageService; }
        }

        private List<Control> BaseControls
        {
            get { return _baseControls; }
        }

        private void InitializeBaseControls()
        {
            _baseControls = new List<Control>();
            foreach (Control control in this.Controls)
            {
                BaseControls.Add(control);
            }
            InitializeBaseSizeHeight();
        }

        public List<string> NamesAndLoginsReceivers
        {
            set
            {
                nameAndLoginReceivers.Clear();
                foreach (string nameAndLogins in value)
                {
                    nameAndLoginReceivers.Add(nameAndLogins);
                }
            }
            get { return nameAndLoginReceivers; }
        }

    /*    private void AddReceiversB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fullContentLetterControl1.NameReceiver)) MessageService.ErrorMessage(Registrstion.WinForms.Message.MessageResource.NonexistWorker);
            else
            {
                nameAndLoginReceivers.Add(fullContentLetterControl1.NameReceiver);
            }
        }*/

        private void CreateLetter(string letterName, Guid workerId, IEnumerable<string> workerNameAndLogin, string letterText, string extendedData, int type)
        {
            ClientRequests.CreateLetter(letterName, ((ApplicationState)ServiceProvider.GetService(typeof(ApplicationState))).Worker.Id, workerNameAndLogin, letterText, extendedData, type);
        }

        private bool SendLetter(string letterName, Guid workerId, IEnumerable<string> workerNameAndLogin, string letterText, string extendedData, int type)
        {
            if (string.IsNullOrEmpty(letterName))
            {
                MessageService.ErrorMessage(Message.MessageResource.EmptyNameInLetter);
                return false;
            }
            if (workerNameAndLogin.Count() == 0)
            {
                MessageService.ErrorMessage(Message.MessageResource.EmptyListRecipient);
                return false;
            }

            CreateLetter(letterName, ((ApplicationState)ServiceProvider.GetService(typeof(ApplicationState))).Worker.Id, workerNameAndLogin, letterText, extendedData, type);
            return true;
        }

        private void SendLetterB_Click(object sender, EventArgs e)
        {
            LetterType selectedLetterType = ((ApplicationState)ServiceProvider.GetService(typeof(ApplicationState))).SelectedLetterType;
            ILetterPropertiesUIPlugin clientUIPlugin = ((PluginService)(ServiceProvider.GetService(typeof(PluginService)))).GetLetterPropetiesPlugin(selectedLetterType);

            global::Registration.SerializationService.LetterProperties letterProp = clientUIPlugin.GetLetterProperties();
            LetterView letterView = clientUIPlugin.StandartLetter;

         if (SendLetter(letterView.Name, ((ApplicationState)ServiceProvider.GetService(typeof(ApplicationState))).Worker.Id, NamesAndLoginsReceivers, letterView.Text, letterProp.ToString(), selectedLetterType.Id)) 
            {
                MessageService.InfoMessage(Message.MessageResource.SentLetter);
                Close();
            }
        }

        private IEnumerable<string> GetAllWorkers()
        {
            return ClientRequests.GetAllWorkers();
        }

        private string GetWorkerName(Guid workerId)
        {
            return ClientRequests.GetWorkerName(workerId);
        }

        private void InitializeClientService()
        {
            _clientRequests = (IClientRequests)ServiceProvider.GetService(typeof(IClientRequests));
        }

        private void InitializeMessageService()
        {
            _messageService = (Message.IMessageService)ServiceProvider.GetService(typeof(Message.IMessageService));
        }

        private void InitializeBaseSizeHeight()
        {
            _baseSizeHeight = new Point(this.Size.Width, this.Size.Height);
        }

        private void InitializeForm()
        {
            InitializeClientService();
            InitializeMessageService();

            var selectedLetterType = ((ApplicationState)ServiceProvider.GetService(typeof(ApplicationState))).SelectedLetterType;

            
            ILetterPropertiesUIPlugin newControl = ((PluginService)(ServiceProvider.GetService(typeof(PluginService)))).GetLetterPropetiesPlugin(selectedLetterType);
         //   newControl.AddReceiver += new EventHandler(Click);
            newControl.ReadOnly = false;

            this.Size = new Size(((Control)newControl).Size.Width, ((Control)newControl).Height);
            this.Controls.Add(((Control)newControl));
        }

       /* private void Click(object sender, EventArgs e)
        {
         //   MessageBox.Show(((ILetterPropertiesUIPlugin)sender).Properties.ToString());

          //  ILetterPropertiesUIPlugin clientUIPlugin = ((PluginService)(ServiceProvider.GetService(typeof(PluginService)))).GetLetterPropetiesPlugin(selectedLetterType);
            this.Close();
        }*/

        private void MakeLetterForm_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeForm();
            }
            catch (Exception ex)
            {
                NLogger.Logger.Error(ex.ToString());
            }
        }
    }
}