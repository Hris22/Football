// See https://aka.ms/new-console-template for more information
using Football;

internal class Program
{
    private static void Main(string[] args)
    {
        //Team 1 
        Striker striker1 = new Striker("Ivan", 15, 16, 178);
        Striker striker2 = new Striker("Dimitar", 18, 5, 180);
        Striker striker3 = new Striker("Stoil", 15, 8, 183);
        Midfield midfield1 = new Midfield("Petar", 17, 17, 168);
        Midfield midfield2 = new Midfield("Martin", 18, 12, 169);
        Midfield midfield3 = new Midfield("Valeri", 19, 17, 178);
        Defender defender1 = new Defender("Stamen", 19, 9, 172);
        Defender defender2 = new Defender("Valentin", 19, 42, 170);
        Defender defender3 = new Defender("Stefan", 16, 31, 174);
        Goalkeeper goalkeeper1 = new Goalkeeper("Hristo", 17, 2, 175);
        Goalkeeper goalkeeper2 = new Goalkeeper("Vladimir", 18, 22, 180);

        Team team1 = new Team();
        team1.AddPlayer(striker1);
        team1.AddPlayer(striker2);
        team1.AddPlayer(striker3);
        team1.AddPlayer(midfield1);
        team1.AddPlayer(midfield2);
        team1.AddPlayer(midfield3);
        team1.AddPlayer(defender1);
        team1.AddPlayer(defender2);
        team1.AddPlayer(defender3);
        team1.AddPlayer(goalkeeper1);
        team1.AddPlayer(goalkeeper2);

        Console.WriteLine("Team1 avarege height is " + team1.AvaregeAgeOfPlayers());

        Coach coach1 = new Coach("Hristiyan", 42);
        team1.AddCoach(coach1);

        //Team 2 
        Striker striker1t2 = new Striker("Momchil", 15, 16, 178);
        Striker striker2t2 = new Striker("Martin", 18, 5, 180);
        Striker striker3t2 = new Striker("Stoil", 15, 8, 183);
        Midfield midfield1t2 = new Midfield("Dimitar", 17, 17, 168);
        Midfield midfield2t2 = new Midfield("Martin", 18, 12, 169);
        Midfield midfield3t2 = new Midfield("Valeri", 19, 17, 178);
        Defender defender1t2 = new Defender("Hristiyan", 14, 9, 172);
        Defender defender2t2 = new Defender("Valentin", 29, 42, 170);
        Defender defender3t2 = new Defender("Stefanos", 19, 31, 174);
        Goalkeeper goalkeeper1t2 = new Goalkeeper("Kristo", 17, 2, 175);
        Goalkeeper goalkeeper2t2 = new Goalkeeper("Ivan", 18, 22, 180);

        Team team2 = new Team();
        team2.AddPlayer(striker1t2);
        team2.AddPlayer(striker2t2);
        team2.AddPlayer(striker3t2);
        team2.AddPlayer(midfield1t2);
        team2.AddPlayer(midfield2t2);
        team2.AddPlayer(midfield3t2);
        team2.AddPlayer(defender1t2);
        team2.AddPlayer(defender2t2);
        team2.AddPlayer(defender3t2);
        team2.AddPlayer(goalkeeper1t2);
        team2.AddPlayer(goalkeeper2t2);

        Console.WriteLine("Team2 avarege height is " + team2.AvaregeAgeOfPlayers());

        Coach coach1t2 = new Coach("Boris", 52);
        team2.AddCoach(coach1t2);

        // Refeeres
        Referee refeeree1 = new Referee("Vasil", 25,"main");
        Referee refeereeAss1 = new Referee("Nikola", 28, "assistant");
        Referee refeereeAss2 = new Referee("Milko", 30,"assistant");

        //Goals
        Game game1 = new Game();
        game1.AddGoals("27min-Ivan","team1");
        game1.AddGoals("30min_Vasil","team2");
        game1.AddGoals("40min_Vasil", "team2");

        game1.GameResult();

    }
}