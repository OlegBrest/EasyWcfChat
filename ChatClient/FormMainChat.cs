using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
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
        EndpointAddress ServerEndPoint = new EndpointAddress("net.tcp://localhost:8734/");
        string endpointConfigurationName = "NetTcpBinding_IServiceChat"; // <netTcpBinding> <binding name = ... and <client> bindingConfiguration in app.config
        System.Timers.Timer connectCheckTimer;

        public FormMainChat()
        {
            InitializeComponent();
            userName = Properties.Settings.Default.UserName;
            ServerEndPoint = new EndpointAddress(@"net.tcp://" + Properties.Settings.Default.serverAddress.ToString() + ":" + Properties.Settings.Default.ServerPort.ToString() + @"/");
            mainFormInterfaceUpdate();
            connectCheckTimer = new System.Timers.Timer(2000);
            connectCheckTimer.AutoReset = true;
            connectCheckTimer.Start();
            connectCheckTimer.Elapsed += ConnectCheckTimer_Elapsed;
        }

        private void ConnectCheckTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (isConnected)
            {
                try
                {
                    client.SendMsg("ConnectTesting", 0);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Коммуникационный объект System.ServiceModel.Channels.ServiceChannel нельзя использовать для связи, так как он находится в состоянии Faulted."))
                    {
                        try
                        {
                            client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this), endpointConfigurationName, ServerEndPoint);
                            ConnectItem_Click(this, null);
                            client.SendMsg("ConnectTesting", 0);
                        }
                        catch (Exception reconnectEx)
                        {
                            listBoxInvokAdder(lstbxMainChat, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " Ошибка связи с сервером");
                            listBoxInvokAdder(lstbxMainChat, " " + reconnectEx.Message);
                        }
                        listBoxInvokAdder(lstbxMainChat, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + " Переподклечен к серверу.");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ConnectItem_Click(object sender, EventArgs e)
        {
            if ((client == null) || (client.State != CommunicationState.Created))
            {
                client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this), endpointConfigurationName, ServerEndPoint);
            }
            int newID = client.Connect(userName,ID);
            if ((newID == -1) || ((newID != ID) && (ID != -1))) MessageBox.Show("Пользователь с ником " + userName + " уже зарегистрирован на сервере!");
            else ID = newID;
            client.SendMsg(" Init " + userName, 0);
            mainFormInterfaceUpdate();
        }

        private void DisconnectItem_Click(object sender, EventArgs e)
        {
            isConnected = false;
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
                #region changing User Name and connect properties
                Properties.Settings.Default.Reload();
                userName = Properties.Settings.Default.UserName;
                string serverAddress = @"net.tcp://" + Properties.Settings.Default.serverAddress.ToString() + ":" + Properties.Settings.Default.ServerPort.ToString() + @"/";
                ServerEndPoint = new EndpointAddress(serverAddress);
                client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this), endpointConfigurationName, ServerEndPoint);
                mainFormInterfaceUpdate();
                #endregion
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
                //listBoxInvokAdder(lstbxMainChat,msg);
            }
            else
                listBoxInvokAdder(lstbxMainChat, msg);
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
            client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this), endpointConfigurationName, ServerEndPoint);
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
            try
            {
                client.SendMsg(txtbxMssg.Text, ID);
                txtbxMssg.Text = string.Empty;
                txtbxMssg.Focus();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("System.ServiceModel.Channels.ServiceChannel") && (client.State == CommunicationState.Faulted))
                {
                    try
                    {
                        client = new ServiceChatClient(new System.ServiceModel.InstanceContext(this), endpointConfigurationName, ServerEndPoint);
                        ConnectItem_Click(this, null);
                        client.SendMsg(txtbxMssg.Text, ID);
                        txtbxMssg.Text = string.Empty;
                        txtbxMssg.Focus();
                    }
                    catch (Exception reconnectEx)
                    {
                        listBoxInvokAdder(lstbxMainChat, " Ошибка связи с сервером");
                        listBoxInvokAdder(lstbxMainChat, " " + reconnectEx.Message);
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listBoxInvokAdder(ListBox listBox, string msg)
        {
            if (listBox.InvokeRequired)
            {
                listBox.Invoke((MethodInvoker)delegate
                {
                    listBox.Items.Add(msg);
                });
            }
            else
            {
                listBox.Items.Add(msg);
            }
        }
    }
}
