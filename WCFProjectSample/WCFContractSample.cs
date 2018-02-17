using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WCFProjectSample
{
    [DataContract]
    public class EchoMessageSample
    {
        private string _OutMessage;
        private string _RetrunMessage;

        [DataMember]
        public string OutMessage {
            get { return _OutMessage; }
            set { _OutMessage = value; }
        }

        [DataMember]
        public string RetrunMessage
        {
            get { return _RetrunMessage; }
            set { _RetrunMessage = value; }
        }
    }
}
