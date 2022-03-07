namespace OlympicGames.Models
{
    public class Team
    {
        public string TeamId { get; set; }
        public string Name { get; set; }
        public Game Game { get; set; }
        public Sport Sport { get; set; }
        public string LogoImage { get; set; }
        public string GameId { get; internal set; }
        public string SportId { get; internal set; }
    }
}
