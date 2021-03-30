using SamuraiBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SamuraiBattle.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISamuraiService
    {
        [OperationContract]
        IList<Samurai> GetAllSamurais(int id);

        [OperationContract]
        Samurai GetSamuraiById(int id);

        [OperationContract]
        bool UpdateSamurai(string name, int age, string town);
        
        // TODO: Add your service operations here
    }

   
}
