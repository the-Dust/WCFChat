using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_MyChat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyChatService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyChatService.svc or MyChatService.svc.cs at the Solution Explorer and start debugging.
    public class MyChatService : IMyChatService
    {
        static List<string> messages = new List<string>();

        public string GetChat()
        {
            return string.Join(Environment.NewLine, messages);
        }

        public void SendMessage(string message)
        {
            messages.Add(message);
        }
    }
}
