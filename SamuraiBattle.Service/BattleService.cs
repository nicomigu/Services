using SamuraiBattle.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiBattle.Service
{
    public class BattleService : IBattleService
    {
        public IList<Battle> GetAllBattles()
        {
            throw new NotImplementedException();
        }

        public Battle GetBattleById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBattle(string Name, DateTime dateStart, string city, string country)
        {
            throw new NotImplementedException();
        }
    }
}
