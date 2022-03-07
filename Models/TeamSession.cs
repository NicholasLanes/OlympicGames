using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace OlympicGames.Models
{
    public static class SessionExtensions
    {
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return (value == null) ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
    public class TeamSession
    {
        private const string TeamKey = "myteams";
        private const string CountKey = "teamcount";
        private const string GameKey = "game";
        private const string SportKey = "sport";

        private ISession session { get; set; }
        public TeamSession(ISession session)
        {
            this.session = session;
        }

        public void SetMyTeams(List<Team> teams)
        {
            session.SetObject(TeamKey, teams);
            session.SetInt32(CountKey, teams.Count);
        }
        public List<Team> GetMyTeams() =>
            session.GetObject<List<Team>>(TeamKey) ?? new List<Team>();
        public int? GetMyTeamCount() => session.GetInt32(CountKey) ?? 0;
        public void SetActiveGame(string activeGame) =>
            session.SetString(GameKey, activeGame);
        public string GetActiveGame() => session.GetString(GameKey);
        public void SetActiveSport(string activeSport)=>
            session.SetString(SportKey, activeSport);
        public string GetActiveSport() => session.GetString(SportKey);
        public void RemoveMyTeams()
        {
            session.Remove(TeamKey);
            session.Remove(CountKey);
        }

    }
}
