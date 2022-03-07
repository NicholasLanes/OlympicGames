using System.Collections.Generic;

namespace OlympicGames.Models
{
    public class TeamListViewModel:TeamViewModel
    {
        public List<Team> Teams { get; set; }

        //Team, Active Game, and Active Sport are inherited

        //make next two properties standard properties os the setter can make the first item in each list "All"
        private List<Sport> sports;
        public List<Sport> Sports
        {
            get => sports;
            set
            {
                sports = value;
                sports.Insert(0,
                    new Sport { SportId = "all", Name = "All" });
            }
        }
        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0,
                    new Game { GameId = "all", Name = "All" });
            }
        }

        //methods to help view determine the active link
        public string CheckActiveSport(string s) => s.ToLower() == ActiveSport.ToLower() ? "active" : "";
        public string CheckActiveGame(string g) => g.ToLower() == ActiveGame.ToLower() ? "active" : "";
    }
}
