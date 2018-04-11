using System;
using System.Windows.Forms;
using Registration.Model;
using Registration.ClientInterface;
using System.ComponentModel.Design;
using Registration.Logger;

namespace Registrstion.WinForms.Forms
{
    internal partial class FullContentLetterForm : Form
    {
        private IClientRequests _clientRequests;
        private Message.IMessageService _messageService;

        public FullContentLetterForm()
        {
            InitializeComponent();
        }

        public IClientRequests ClientRequests
        {
            get { return _clientRequests;  }
        }

        public Message.IMessageService MessageService
        {
            get { return _messageService;  }
        }

        private void InitializeClientService()
        {
            _clientRequests = (IClientRequests)Program.GetServiceContainer().GetService(typeof(IClientRequests));
        }

        private void InitializeMessageService()
        {
            _messageService = (Message.IMessageService)Program.GetServiceContainer().GetService(typeof(Message.IMessageService));
        }

        public void InitializeForm()
        {
            InitializeClientService();
            InitializeMessageService();

            fullContentLetterControl1.FullContent = Program.LetterView;
        }

        private void fullContentLetterControl1_Load(object sender, EventArgs e)
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

        private void DeleteLetter(LetterView letterView, Guid workerId)
        {
            ClientRequests.DeleteLetter(letterView, workerId);
        }

        private void deleteLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageService.QuestionMessage(Registrstion.WinForms.Message.MessageResource.DeleteLetter) == DialogResult.Yes)
            {
                DeleteLetter(Program.LetterView, Program.WorkerId);
                Close();
            }
        }
    }
}
