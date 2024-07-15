using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    internal class Match
    {
        private string teamHome;
        private string teamAway;
        private DateTime date;
        private Competition competition;

        private Dictionary<int, int> prices;

        public Match(string teamHome, string teamAway, DateTime date, Competition competition)
        {
            this.teamHome = teamHome;
            this.teamAway = teamAway;
            this.date = date;
            this.competition = competition;
        }
        public string TeamHome { get {  return teamHome; } }
        public string TeamAway { get {  return teamAway; } }
        public DateTime Date { get { return date; } }
        public Competition Competition { get {  return competition; } }
    }
}
