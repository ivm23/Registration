using System;
using System.Windows.Forms;
using Registration.Model;
using Registration.ClientInterface;
using System.ComponentModel.Design;
using Registration.Logger;
using System.Drawing;
using System.Collections.Generic;
using System.Xml;

namespace Registrstion.WinForms.Forms
{
    internal partial class FullContentLetterForm : Form
    {
        private IClientRequests _clientRequests;
        private Message.IMessageService _messageService;
        private readonly IServiceProvider _serviceProvider;

        private List<Control> _baseControls;
        private Point _baseSizeHeight;

        public FullContentLetterForm(IServiceProvider provider)
        {
            _serviceProvider = provider;
            InitializeComponent();
        }

        private Point BaseSizeHeight
        {
            get { return _baseSizeHeight; }
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

        private void InitializeBaseSizeHeight()
        {
            _baseSizeHeight = new Point(this.Size.Width, this.Size.Height);
        }

        private IServiceProvider ServiceProvider => _serviceProvider;

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
            _clientRequests = (IClientRequests)ServiceProvider.GetService(typeof(IClientRequests));
        }

        private void InitializeMessageService()
        {
            _messageService = (Message.IMessageService)ServiceProvider.GetService(typeof(Message.IMessageService));
        }

        public void InitializeForm()
        {
            InitializeClientService();
            InitializeMessageService();
            InitializeBaseControls();

            LetterView letterView = ((ApplicationState)ServiceProvider.GetService(typeof(ApplicationState))).SelectedLetterView;

            LetterType selectedLetterType = ClientRequests.GetLetterType(letterView.Type);

        
            ILetterPropertiesUIPlugin newControl = ((PluginService)(ServiceProvider.GetService(typeof(PluginService)))).GetLetterPropetiesPlugin(selectedLetterType);
            //newControl. = false;
            FolderProperties prop = new FolderProperties() { };

            XmlElement elem = prop.Info.CreateElement(letterView.ExtendedData);
            elem.InnerText = letterView.ExtendedData;
            prop.Info.AppendChild(elem);

            newControl.Info = prop;
           
            fullContentLetterControl1.FullContent = letterView;

            int minXLocation = int.MaxValue;
            int minYLocation = int.MaxValue;
            int sizeForMinYLocation = 0;

            foreach (Control control in BaseControls)
            {
                minXLocation = Math.Min(control.Location.X, minXLocation);
                
                if (control.Location.Y < minYLocation)
                {
                    minYLocation = control.Location.Y;
                    sizeForMinYLocation = control.Size.Height;
                }
            }
            ((Control)newControl).Location = new Point(minXLocation, minYLocation + sizeForMinYLocation);

            int width = Math.Max(BaseSizeHeight.X, ((Control)newControl).Width);

            this.Controls.Clear();

            this.Size = new Size(width, BaseSizeHeight.Y + ((Control)newControl).Size.Height);
       
            this.Controls.Add(((Control)newControl));
            
            foreach (Control control in BaseControls)
            {
                control.Location = new System.Drawing.Point(control.Location.X, control.Location.Y + ((Control)newControl).Size.Height);
                this.Controls.Add(control);
            }
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
                DeleteLetter(((ApplicationState)ServiceProvider.GetService(typeof(ApplicationState))).SelectedLetterView, ((ApplicationState)ServiceProvider.GetService(typeof(ApplicationState))).Worker.Id);
                Close();
            }
        }
    }
}
