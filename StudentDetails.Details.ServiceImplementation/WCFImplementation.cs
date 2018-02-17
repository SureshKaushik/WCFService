using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using StudentDetails.Details.DataContracts;
using StudentDetails.Details.ServiceContracts;

namespace StudentDetails.Details.ServiceImplementation
{
    class EchoImplementation : IEchoContract
    {
        public EchoMessage Echo(EchoMessage Message)
        {
            EchoMessage _returningMessage = new EchoMessage();

            _returningMessage.ReturnMessage = Message.OutMessage;

            return _returningMessage;
        }
    }
}
