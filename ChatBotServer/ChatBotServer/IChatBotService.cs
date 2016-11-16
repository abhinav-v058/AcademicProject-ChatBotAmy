using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatBotServer
{
    [ServiceContract]
    public interface IChatBotService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        ChatData GetDataUsingDataContract(ChatData composite);
                
    }
        
    [DataContract]
    public class ChatData
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
