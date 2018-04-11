using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using Registration.ClientInterface;
using Registration.Model;

namespace Registrstion.WinForms
{
    static class Program
    {
        private static ServiceContainer _serviceContainer = new ServiceContainer();
        private static string _connectionString = "Data Source = 109PC0047; Initial Catalog = RegistrationWithFolders.DB; Integrated Security = True";
        private static Guid _workerId;
        private static LetterView _letterView;
        private static Folder _folder;
        private static CloseReason _closeReason;
        public static ServiceContainer GetServiceContainer()
        {
            return _serviceContainer;            
        }
        
        public static CloseReason CloseReason
        {
            set { _closeReason = value; }
            get { return _closeReason; }
        }
        public static Guid WorkerId
        {
            set { _workerId = value; }
            get { return _workerId; }
        }

        public static Folder Folder
        {
            set { _folder = value; }
            get { return _folder;  }
        }
        public static LetterView LetterView
        {
            set {_letterView = value; }
            get { return _letterView; }
        }

        public static string ConnectionString
        {
            set { _connectionString = value; }
            get { return _connectionString; }
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            IClientRequests clientRequests = new ClientRequests(_connectionString);
           
            _serviceContainer.AddService(typeof(IClientRequests), clientRequests);
            _serviceContainer.AddService(typeof(PluginService), new PluginService(_serviceContainer));
            _serviceContainer.AddService(typeof(Message.IMessageService), new Message.MessageService());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainWorkerForm());
        }
    }
}
