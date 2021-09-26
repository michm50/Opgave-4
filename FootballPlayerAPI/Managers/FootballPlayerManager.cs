using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sport;

namespace FootballPlayerAPI.Managers
{
    public class FootballPlayerManager
    {
        private static List<FootballPlayer> _players = new List<FootballPlayer>()
        {
            new FootballPlayer(1, "Martin Hansen", 149.00m, 22),
            new FootballPlayer(2, "Foliak Chunkyboi", 243.88m, 99),
            new FootballPlayer(3, "Richard Fawkes", 399.00m, 48),
            new FootballPlayer(4, "Helle etellerandet", 2315782345.00m, 1)
        };

        public List<FootballPlayer> Get()
        {
            return new List<FootballPlayer>(_players);
        }

        public FootballPlayer Get(int id)
        {
            return _players.Find(p => p.Id == id);
        }

        public List<FootballPlayer> GetName(string name)
        {
            return _players.FindAll(p => p.Name.ToLower().StartsWith(name.ToLower()));
        }

        public bool Create(FootballPlayer player)
        {
            if (Get(player.Id) != null)
            {
                _players.Add(player);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(int id, FootballPlayer player)
        {
            if (Get(id) != null)
            {
                _players[_players.FindIndex(i => i.Id == id)] = player;
                return true;
            }
            else
            {
                return false;
            }
        }

        public FootballPlayer Delete(int id)
        {
            if (Get(id) != null)
            {
                FootballPlayer player = Get(id);
                _players.Remove(player);
                return player;
            }
            else
            {
                return null;
            }
        }
    }
}
