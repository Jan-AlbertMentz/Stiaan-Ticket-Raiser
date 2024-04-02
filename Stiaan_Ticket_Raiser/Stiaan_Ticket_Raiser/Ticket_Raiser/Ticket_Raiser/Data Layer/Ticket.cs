using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Raiser.Presentation_Layer
{
    public class Ticket
    {

        private int ticketID;
        private string description;
        private float balance;
        private bool completed;
        private string personName;
        private string personSurname;

        public int TicketID { get => ticketID; set => ticketID = value; }
        public string PersonName { get => personName; set => personName = value; }
        public string PersonSurname { get => personSurname; set => personSurname = value; }
        public string Description { get => description; set => description = value; }
        public float Balance { get => balance; set => balance = value; }
        public bool Completed { get => completed; set => completed = value; }

        public Ticket(int ticketID, string personName, string personSurname, string description, float balance, bool completed)
        {
            this.TicketID = ticketID;
            this.PersonName = personName;
            this.PersonSurname = personSurname;
            this.Description = description;
            this.Balance = balance;
            this.Completed = completed;
        }

        public string ToString()
        {
            return base.ToString();
        }
    }
}
