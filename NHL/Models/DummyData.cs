using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHL.Models
{
    public class DummyData
    {
        public static List<Team> getTeams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team()
                {
                    TeamName = "Canucks",
                    City = "Vancouver",
                    Province = "BC"
                },
                new Team()
                {
                    TeamName = "Oilers",
                    City = "Edmonton",
                    Province = "Alberta"
                },
                 new Team()
                 {
                     TeamName = "Flames",
                     City = "Calagary",
                     Province = "Alberta"
                 },

            };
            return teams;
        }
        public static List<Player> getPlayers(ApplicationDbContext context)
        {
            List<Player> players = new List<Player>()
        {
            new Player()
            {
                FirstName = "Sven",
                LastName = "Baertschi",
                TeamName = context.Teams.Find("Canucks").TeamName,
                Position = "Forward"
            },
            new Player()
            {
                FirstName = "Henrik",
                LastName = "Sedin",
                TeamName = context.Teams.Find("Canucks").TeamName,
                Position = "Left Wing"
            },
            new Player()
            {
                FirstName = "John",
                LastName = "Rooster",
                TeamName = context.Teams.Find("Flames").TeamName,
                Position = "Right Wing"
            },
            new Player()
            {
                FirstName = "Bob",
                LastName = "Plumber",
                TeamName = context.Teams.Find("Oilers").TeamName,
                Position = "Defense"
            },
        };
            return players;
        }


    }

}