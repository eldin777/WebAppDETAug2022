using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System.Reflection;

namespace MVCDemo.Controllers
{
    public class EventsController : Controller
    {
        public List<Booking>events { get;  set; }
        public IActionResult index()
        {
            events = new List<Booking>();
            events.Add(new Booking { Title = "Ask CEO", EventDate = DateTime.Today, Qty = 10 });
            return View(events);
        }
    }
}
