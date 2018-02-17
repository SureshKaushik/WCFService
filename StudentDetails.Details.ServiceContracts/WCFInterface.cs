using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using StudentDetails.Details.DataContracts;


namespace StudentDetails.Details.ServiceContracts
{
    [ServiceContract]
    public interface IEchoContract
    {
        [OperationContract]
        EchoMessage Echo(EchoMessage Message);
    }
}
