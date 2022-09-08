using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages
{
    public class IPLEventsModel : PageModel
    {
        public List<Tickets> Ticket{ get; set; }
        public void OnGet()
        {
            Ticket = new List<Tickets>{
            new Tickets{ID=1,Category="PlatinumPlus",Price=5000,MaxLimit=200000},
            new Tickets{ID=2,Category="Platinum",Price=4000,MaxLimit=300000},
            new Tickets{ID=3,Category="Gold",Price=3000,MaxLimit=500000},
            new Tickets{ID=4,Category="Silver",Price=2000,MaxLimit=500000},
            new Tickets{ID=5,Category="General",Price=8000,MaxLimit=100000}
            };
        }
    }
}
