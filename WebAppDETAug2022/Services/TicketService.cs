using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Services
{
    public class TicketService
    {
        static List<Tickets> Ticket { get; }
        static int nextId = 3;
        static TicketService()
        {
            Ticket = new List<Tickets>
                {
                    new Tickets { ID=1,Category="PlatinumPlus",Price=5000,MaxLimit=200000},
                    new Tickets { ID=2,Category="Platinum",Price=4000,MaxLimit=300000 },
                    new Tickets { ID=3,Category="Gold",Price=3000,MaxLimit=500000 },
                    new Tickets { ID=4,Category="Silver",Price=2000,MaxLimit=500000 },
                    new Tickets { ID=5,Category="General",Price=8000,MaxLimit=100000 },
                };
        }
        public static List<Tickets> GetAll() => Ticket;

       // public static Tickets? Get(int id) => Ticket.FirstOrDefault(p => p.Id == id);

        public static void Add(Tickets Tickets)
        {
            Ticket.Add(Tickets);
        }

        //public static void Delete(int id)
        //{
        //    var Tickets = Get(id);
        //    if (Tickets is null)
        //        return;

        //    Ticket.Remove(Tickets);
        //}

        private static object Get(int id)
        {
            throw new NotImplementedException();
        }

        //public static void Update(Tickets Tickets)
        //{
        //    var index = Ticket.FindIndex(p => p.Id == Tickets.Id);
        //    if (index == -1)
        //        return;

        //    Ticket[index] = Tickets;
        //}
    }
}