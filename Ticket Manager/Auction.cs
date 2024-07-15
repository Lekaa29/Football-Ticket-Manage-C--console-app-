using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    internal class Auction
    {
        
        private Stadium venue;
        private Match match;
        private int price;
        private string stand;
        private List<string> seats;
        

        public Auction(Stadium venue, Match match, string stand, List<string> seats, int price)
        {
            this.seats = seats;
            this.venue = venue;
            this.match = match;
            this.price = price;
            this.stand = stand;
        }

        public int GetAvailable() { return  seats.Count; }
        public int Price {  get { return price; } }
        public Stadium Stadium { get { return this.venue; } }
        public Match Match { get { return this.match; } }
        public string Stand { get { return this.stand; } }
        public string GetSeat () 
        {
            string seat = seats[0];
            seats.RemoveAt(0);
            return seat;
        }

        public void AddSeat(string seat)
        {
            seats.Add(seat);
        }

    }
}
