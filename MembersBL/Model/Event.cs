using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersBL.Model
{
    public class Event
    {
        public Event(int id, string name, DateTime date, double ticketCost, string address)
        {
            Id = id;
            Name = name;
            Date = date;
            TicketCost = ticketCost;
            Address = address;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double TicketCost { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"{Name} ({Date})";
        }
    }
}
