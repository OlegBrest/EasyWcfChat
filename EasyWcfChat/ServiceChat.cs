using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace EasyWcfChat
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceChat : IServiceChat
    {

        List<ServerUser> users = new List<ServerUser>();
        int nextId = 0;

        public int Connect(string userName)
        {
            if (users.FirstOrDefault(x => x.Name == userName) == null)
            {
                ServerUser user = new ServerUser()
                {
                    ID = ++nextId,
                    Name = userName,
                    operationContext = OperationContext.Current
                };
                SendMsg(" " + user.Name + " ворвался в чат", 0);
                users.Add(user);
                ResendUsersList();
                return nextId;
            }
            else return -1;
        }

        public void Disconnect(int id)
        {
            ServerUser user = users.FirstOrDefault(x => x.ID == id);
            if (user != null)
            {
                users.Remove(user);
                SendMsg(" " + user.Name + " покинул чат", 0);
            }
            ResendUsersList();
        }

        public void SendMsg(string msg, int id)
        {
            foreach (ServerUser currentUser in users)
            {
                string answer = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                ServerUser user = users.FirstOrDefault(x => x.ID == id);
                bool isSystem = (user == null);
                if (!isSystem)
                {
                    answer += (" : " + user.Name + " ");
                }
                answer += msg;
                currentUser.operationContext.GetCallbackChannel<IServerChatCallback>().MsgCallback(UsersToString(), true);
                currentUser.operationContext.GetCallbackChannel<IServerChatCallback>().MsgCallback(answer, isSystem);
            }
        }

        public void ResendUsersList ()
        {
            foreach (ServerUser currentUser in users)
            {
               if (currentUser.ID!=nextId) SendMsg(1, currentUser);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command">1 - userslist</param>
        /// <param name="id"></param>
        public void SendMsg(int command, ServerUser user)
        {
            if (command == 1)
            {
                if(user!=null) user.operationContext.GetCallbackChannel<IServerChatCallback>().MsgCallback(UsersToString(),true);
            }
        }

        private string UsersToString ()
        {
            string stringUsers = "Users:";
            foreach (ServerUser currentUser in users) {
                if (stringUsers!= "Users:")
                {
                    stringUsers += "|";
                }
                stringUsers += currentUser.Name; 
            }
            return stringUsers;
        }
    }
}
