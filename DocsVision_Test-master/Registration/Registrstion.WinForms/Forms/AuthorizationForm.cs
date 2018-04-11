using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Registration.ClientInterface;
using System.ComponentModel.Design;
using Registration.Logger;

namespace Registrstion.WinForms
{
    internal partial class Registration : Form
    {
        private IClientRequests _clientRequests;
        private Message.IMessageService _messageService;
 
        IDictionary<string, string> databaseNamesAndConnectionStrings;

        public Registration()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(singUp_Closing);            
        }

        private IClientRequests ClientRequests
        {
            get { return _clientRequests; }
        }

        private Message.IMessageService MessageService
        {
            get { return _messageService; }
        }

        private void InitializeForm()
        {
            InitializeClientService();
            InitializeMessage();

            databaseNamesAndConnectionStrings = ClientRequests.GetDatabaseNamesAndConnectionStrings();

            foreach (KeyValuePair<string,string> nameAndConnectionString in databaseNamesAndConnectionStrings)
            {
                databaseNamesCB.Items.Add(nameAndConnectionString.Key);
            }
            databaseNamesCB.SelectedItem = databaseNamesAndConnectionStrings.First().Key;
        }

        private void InitializeClientService()
        {
            _clientRequests = (IClientRequests)Program.GetServiceContainer().GetService(typeof(IClientRequests));
        }

        private void InitializeMessage()
        {
            _messageService = (Message.IMessageService)Program.GetServiceContainer().GetService(typeof(Message.IMessageService));
        }

        private void Registration_Load(object sender, EventArgs e)
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

        private Guid AcceptAuthorisation(string workerLogin, string workerPassword)
        {
            return ClientRequests.AcceptAuthorisation(workerLogin, workerPassword);
        }

        private Guid SingIn(string workerLogin, string workerPassword)
        {
            Guid workerId = Guid.Empty;
            if (string.IsNullOrEmpty(workerLogin) || string.IsNullOrEmpty(workerPassword))
            {
                MessageService.ErrorMessage(Registrstion.WinForms.Message.MessageResource.EmptyLoginOrPassword);
            }
            else
            {
                workerId = AcceptAuthorisation(workerLogin, workerPassword);

                if (Guid.Empty.Equals(workerId))
                {
                    MessageService.ErrorMessage(Registrstion.WinForms.Message.MessageResource.WrongLoginOrPassword);
                }
                else
                {
                    MessageService.SingleMessage(Registrstion.WinForms.Message.MessageResource.Welcome);
                }
            }
            return workerId;
        }

        private void singIn_Click(object sender, EventArgs e)
        {
            Program.ConnectionString = databaseNamesAndConnectionStrings[databaseNamesCB.SelectedItem.ToString()];

               Program.WorkerId = SingIn(loginTB.Text, passwordTB.Text);

            if (!Program.WorkerId.Equals(Guid.Empty))
            {
                Hide();
            }
           
        }

        private void singUp_Click(object sender, EventArgs e)
        {
            Hide();
            using (var singUpForm = new Forms.SingUpForm())
            {
                singUpForm.ShowDialog();
            }
            Show();
        }

        private void singUp_Closing(object sender, FormClosingEventArgs e)
        {
            Program.CloseReason = e.CloseReason;
        }
    }

}
