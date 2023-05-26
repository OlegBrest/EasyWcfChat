using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChatClient.ServiceChat;

namespace ChatClient
{
    public partial class FormMainChat : Form, ServiceChat.IServiceChatCallback
    {
        bool isConnected = false;
        string userName = "Имя пользователя";
        ServiceChatClient client;
        int ID = -1;


        public FormMainChat()
        {
            InitializeComponent();
            userName = Properties.Settings.Default.UserName;
            mainFormInterfaceUpdate();
        }

        private void ConnectItem_Click(object sender, EventArgs e)
        {
            ID = client.Connect(userName);
            if (ID == -1) MessageBox.Show("Пользователь с именем " + userName + " уже зарегистрирован на сервере!");
            client.SendMsg(" Init "+userName,0);
            mainFormInterfaceUpdate();
        }

        private void DisconnectItem_Click(object sender, EventArgs e)
        {
            if (client.State == System.ServiceModel.CommunicationState.Opened)
            {
                client.Disconnect(ID);
                ID = -1;
                mainFormInterfaceUpdate();
            }
        }

        private void toolsSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            DialogResult dr = formSettings.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Properties.Settings.Default.Reload();
                userName = Properties.Settings.Default.UserName;
                mainFormInterfaceUpdate();
            }
        }

        private void mainFormInterfaceUpdate()
        {
            if (ID != -1)
            {
                isConnected = true;
            }
            else
            {
                isConnected = false;
            }
            ConnectItem.Enabled = !isConnected;
            DisconnectItem.Enabled = isConnected;
            toolsSettings.Enabled = !isConnected;
            this.Text = "Чат (" + userName + ")" + (isConnected ? " Подключен" : " Отключен");
        }

        public void MsgCallback(string msg, bool isSystem)
        {
            if (isSystem)
            {
                if (msg.Contains("Users:"))
                {
                    UpdateUserList(msg.Split(':')[1]);
                }
                //lstbxMainChat.Items.Add(msg);
            }
            else
                lstbxMainChat.Items.Add(msg);
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

        private void FormMainChat_Load(object sender, EventArgs e)
        {
            client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this));
        }

        private void FormMainChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectItem_Click(this, null);
        }

        private void bttnSend_Click(object sender, EventArgs e)
        {
            sendingMessage();
        }

        private void txtbxMssg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendingMessage();
            }
        }

        private void sendingMessage()
        {
            client.SendMsg(txtbxMssg.Text, ID);
            txtbxMssg.Text = string.Empty;
            txtbxMssg.Focus();
        }
    }
}
