using System;

namespace PCCO104L.Activity7.QUIAMBAO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NBA PLAYERS");
            Console.WriteLine("");

            NBAPlayer Luka = new NBAPlayer("Averaging 34.5 Ppg, 8.8 Rpg, and 9.4 Apg", "Luka Doncic", "SF", "Dallas Mavericks", 77);
            Luka.Information();
            Luka.SetInjuryStatus(false);
            Luka.UpdateAvailability("Available");

            NBAPlayer Kyrie = new NBAPlayer("Averaging 25.6 Ppg, 5.0 Rpg, and 5.2 Apg", "Kyrie Irving", "PG/SG", "Dallas Mavericks", 11);
            Kyrie.Information();
            Kyrie.SetInjuryStatus(true);
            Kyrie.UpdateAvailability("Unavailable");

            NBAPlayer Lebron = new NBAPlayer("Averaging 25.7 Ppg, 7.3 Rpg, and 8.3 Apg", "Lebron James", "SF/PF", "Los Angeles Lakers", 23);
            Lebron.Information();
            Lebron.SetInjuryStatus(false);
            Lebron.UpdateAvailability("Available");
        }
    }

    public class NBAPlayer
    {
        public string PlayerName { get; set; }
        public string Statistics { get; }
        public int JerseyNumber { get; set; }
        private string Team { get; set; }
        private string Position { get; set; }
        private bool IsInjured { get; set; }
        public string Availability { get; set; }

        public NBAPlayer(string stats, string playerName, string position, string team, int jerseyNumber)
        {
            PlayerName = playerName;
            Position = position;
            Team = team;
            JerseyNumber = jerseyNumber;
            Statistics = stats; 
        }

        public void Information()
        {
            Console.WriteLine($"{PlayerName} - Jersey Number: {JerseyNumber}, Team: {Team}, Position: {Position}, Statistics: {Statistics}");
        }

        public void SetInjuryStatus(bool isInjured)
        {
            IsInjured = isInjured;
            Console.WriteLine($"{PlayerName} is {(IsInjured ? "injured" : "not injured")}");
        }

        public void UpdateAvailability(string newAvailability)
        {
            Availability = newAvailability;
            Console.WriteLine($"{PlayerName}'s Availability updated to {Availability}.");
        }
    }
}
