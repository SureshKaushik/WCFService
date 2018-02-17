using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCFProjectSample
{
    class EchoMessageSample : IEchoContractSample
    {
        #region IEchoContractSample Members

        public EchoMessageSample IEchoContractSample.Echo(EchoMessageSample message)
        {
            EchoMessageSample echoMessageSample = new EchoMessageSample();
            echoMessageSample.RetrunMessage = message.OutMessage;
            return echoMessageSample;
        }

        #endregion
    }
}
