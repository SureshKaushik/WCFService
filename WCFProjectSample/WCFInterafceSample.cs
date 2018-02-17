using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCFProjectSample
{
    [ServiceContract]
    interface IEchoContractSample
    {
        [OperationContract]
        EchoMessageSample Echo(EchoMessageSample message);
    }
}
