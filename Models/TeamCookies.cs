using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OlympicGames.Models
{
    public class TeamCookies
    {
        private const string MyTeams = "myteams";
        private const string Delimiter = "-";

        private IRequestCookieCollection requestCookies { get; set; }
        private IResponseCookies responseCookies { get; set; }
        public TeamCookies(IRequestCookieCollection cookies)
        {
            requestCookies = cookies;
        }
        public TeamCookies(IResponseCookies cookies)
        {
            responseCookies = cookies;
        }
        public void SetMyTeamIds(List<Team> myteams)
        {
            List<string> ids = myteams.Select(t => t.TeamId).ToList();
            string idsString = string.Join(Delimiter, ids);
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            RemoveMyTeamIds();//delete old cookies first
            responseCookies.Append(MyTeams, idsString, options);
        }
        public string[] GetMyTeamIds()
        {
            string cookie = requestCookies[MyTeams];
            if (string.IsNullOrEmpty(cookie))
                return new string[] { };//empty string array
            else return cookie.Split(Delimiter);
        }
        public void RemoveMyTeamIds()
        {
            responseCookies.Delete(MyTeams);
        }
    }
}
