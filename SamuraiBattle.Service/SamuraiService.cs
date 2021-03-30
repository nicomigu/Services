using SamuraiBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SamuraiBattle.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class SamuraiService : ISamuraiService
    {
        public IList<Samurai> GetAllSamurais(int id)
        {
            throw new NotImplementedException();
        }

        public Samurai GetSamuraiById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSamurai(string name, int age, string town)
        {
            throw new NotImplementedException();
        }
    }
}
