using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        List<Person> team = new List<Person>();
        List<Football_player> players = new List<Football_player>();

        public void AddPlayer(Football_player a)
        {
            players.Add(a);
            team.Add(a);
        }

        public void AddCoach(Coach a)
        {
            team.Add(a);
        }

        public int AvaregeAgeOfPlayers()
        {
            int totalAge = 0;
            int playerCount = 0;

            foreach (Football_player player in players)
            {
                totalAge += player.Age;
                playerCount++;
            }

            if (playerCount > 0)
            {
                return (int)totalAge / playerCount;
            }
            return 0;
        }

      
    }
}
    