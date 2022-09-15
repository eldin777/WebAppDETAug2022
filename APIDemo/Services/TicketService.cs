using APIDemo.Models;

namespace APIDemo.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                    new Ticket { Id=1,BookedBy="PlatinumPlus",Price=5000,Qty=20},
                    new Ticket { Id=2,BookedBy="Platinum",Price=4000,Qty=30},
                    new Ticket { Id=3,BookedBy="Gold",Price=3000,Qty=50 },
                    new Ticket { Id=4,BookedBy="Silver",Price=2000,Qty=50 },
                    new Ticket { Id=5,BookedBy="General",Price=8000,Qty=100 },
                };
        }
        public static List<Ticket> GetAll() => Tickets;
        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(X => X.Id == id);
            return ticket;
        }
    }
}
