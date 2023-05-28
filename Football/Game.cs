using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        List<string> Team1Goals= new List<string>();
        List<string> Team2Goals = new List<string>();

        public void Referee(Referee a)
        {
            List<Referee> MainReferee = new List<Referee>();
            List<Referee> AssistantReferee = new List<Referee>();

            if (a.Role=="mane")
            {
                MainReferee.Add(a);
            }
            else
                AssistantReferee.Add(a);
        }

        public void AddGoals(string goal,string team)
        {
            if (team == "team1")
            {
                Team1Goals.Add(goal);
            }
            else
                Team2Goals.Add(goal);
           
        }
        public void GameResult()
        {
            int team1Goals = Team1Goals.Count();
            int team2Goals = Team2Goals.Count();

            Console.WriteLine($"Game result is Team1 {team1Goals} : Team2 {team2Goals}");

            if (team1Goals>team2Goals)
            {
                Console.WriteLine("Team1 wins");
            }
            else if (team2Goals>team1Goals)
            {
                Console.WriteLine("Team2 wins!!");
            }
            else Console.WriteLine("Draw");
        }

        
    }
}
