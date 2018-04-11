using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Registration.ClientInterface;
using System.ComponentModel.Design;
using Registration.Logger;
using Registration.Model;

namespace Registrstion.WinForms.Forms
{
    internal partial class MakeLetterForm : Form
    {
        private IClientRequests _clientRequests;
        private Message.IMessageService _messageService;
        private List<string> nameAndLoginReceivers;
        private readonly IServiceProvider _serviceProvider;
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

        private Message.IMessageService MessageService
        {
            get { return _messageService; }
        }

        public string TextLetter
        {
            set { fullContentLetterControl1.TextLetter = value; }
            get { return fullContentLetterControl1.TextLetter; }
        }

        public string NameLetter
        {
            set { fullContentLetterControl1.NameLetter = value; }
            get { return fullContentLetterControl1.NameLetter; }
        }

        public IEnumerable<string> AllWorkers
        {
            set { fullContentLetterControl1.AllWorkers = value; }
            get { return fullContentLetterControl1.AllWorkers; }
        }
        

        public List<string> NamesAndLoginsReceivers
        {
            set
            {
                nameAndLoginReceivers.Clear();
                foreach(string nameAndLogins in value)
                {
                    nameAndLoginReceivers.Add(nameAndLogins);
                }
            }
            get { return nameAndLoginReceivers; }
        }

        private void AddReceiversB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fullContentLetterControl1.NameReceiver)) MessageService.ErrorMessage(Registrstion.WinForms.Message.MessageResource.NonexistWorker);
            else
            {
                nameAndLoginReceivers.Add(fullContentLetterControl1.NameReceiver);
            }
        }

        private void CreateLetter(string letterName, Guid workerId, IEnumerable<string> workerNameAndLogin, string letterText)
        {
            ClientRequests.CreateLetter(letterName, Program.WorkerId, workerNameAndLogin, letterText);
        }

        private bool SendLetter(string letterName, Guid workerId, IEnumerable<string> workerNameAndLogin, string letterText)
        {
            if (string.IsNullOrEmpty(letterName))
            {
                MessageService.ErrorMessage(Registrstion.WinForms.Message.MessageResource.EmptyNameInLetter);
                return false;
            }
            if (workerNameAndLogin.Count() == 0)
            {
                MessageService.ErrorMessage(Registrstion.WinForms.Message.MessageResource.EmptyListRecipient);
                return false;
            }

            CreateLetter(letterName, Program.WorkerId, workerNameAndLogin, letterText);
            return true;
        }

        private void SendLetterB_Click(object sender, EventArgs e)
        {   
            if (SendLetter(NameLetter, Program.WorkerId, NamesAndLoginsReceivers, TextLetter))
            {
                MessageService.InfoMessage(Registrstion.WinForms.Message.MessageResource.SentLetter);

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


        private void InitializeForm()
        {
            InitializeClientService();
            InitializeMessageService();
            fullContentLetterControl1.ReadOnly = false;
            fullContentLetterControl1.NameSender = GetWorkerName(Program.WorkerId);

            AllWorkers = GetAllWorkers();
        }

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
