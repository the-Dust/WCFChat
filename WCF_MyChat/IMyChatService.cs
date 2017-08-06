using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_MyChat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMyChatService" in both code and config file together.
    [ServiceContract]
    public interface IMyChatService
    {
        [OperationContract]
        string GetChat();

        [OperationContract]
        void SendMessage(string message);
    }
}
