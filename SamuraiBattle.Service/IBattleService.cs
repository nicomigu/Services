using SamuraiBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiBattle.Service
{
    [ServiceContract]
    public interface IBattleService
    {
        [OperationContract]
        IList<Battle> GetAllBattles();

        [OperationContract]
        Battle GetBattleById(int id);

        [OperationContract]
        bool UpdateBattle(string Name, DateTime dateStart, string city, string country);

    }
}
