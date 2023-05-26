using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;
using ChatHost.ServiceChat;

namespace ChatHost
{
    public partial class HostForm : Form, ServiceChat.IServiceChatCallback
    {
        public static Thread mainThread;
        ServiceHost host;
        bool isConnected = false;
        string userName = "Server";
        ServiceChat.ServiceChatClient serverclient;
        int ID = -1;

        public HostForm()
        {
            InitializeComponent();
            mainThread = new Thread(ThreadProc);
            host = new ServiceHost(typeof(EasyWcfChat.ServiceChat));
            mainThread.Start();
            //consoleListBox.DataSource = MessagesList;
            consoleListBox.Items.Add("Сервис запущен!");
            consoleListBox.Items.Add("Подключаю сервер");
        }

        public void MsgCallback(string msg, bool isSystem)
        {
            if (isSystem)
            {
                if (msg.Contains("Users:"))
                {
                    UpdateUserList(msg.Split(':')[1]);
                }
                else
                    consoleListBox.Items.Add(msg);
            }
        }

        private void UpdateUserList(string users)
        {
            List<string> serverUsersList = new List<string>();
            string[] usersArray = users.Split('|');
            foreach (string user in usersArray)
            {
                serverUsersList.Add(user);
            }
            serverUsersList.Sort();
            lstbxUsers.DataSource = serverUsersList;
        }

        void ThreadProc()
        {
            host.Open();
        }

        private void HostForm_Load(object sender, EventArgs e)
        {
            try
            {
                serverclient = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
                ID = serverclient.Connect(userName);
                serverclient.SendMsg(" Init " + userName, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (ID == -1)
            {
                consoleListBox.Items.Add("Немогу подключить сервер к сервису");
            }
            else
            {
                consoleListBox.Items.Add("Сервер подключен к сервису");
            }
        }

    }
}
