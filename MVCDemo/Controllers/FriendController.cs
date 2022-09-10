using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Services;
using MVCDemo.Servics;

namespace MVCDemo.Controllers
{
    public class FriendController : Controller
    {


        public List<Friend>? Friends { get; set; }
        public IActionResult Index()
        {
            List<Friend> Friends = FriendServices.GetAll();
            return View(Friends);
        }
        public IActionResult Details(int id)
        {
            Friend f = FriendServices.Get(id);
            return View(f);
        }

        public IActionResult List()
        {
            List<Friend> Friends = FriendServices.GetAll();
            return View(Friends);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Friend f)
        {
            //Pizza p = new Pizza { Id = Id, Name = Name, Size = (PizzaSize)Size, IsGlutenFree = IsGlutenFree, Price = Price };
            FriendServices.Add(f);
            return RedirectToAction("List");
        }


        public IActionResult Delete(int id)
        {
            Friend f = FriendServices.Get(id);
            if (f != null)
                return View(f);
            else
                return RedirectToAction("List");
        }


        [HttpPost]
        public IActionResult Delete(Friend f)
        {
            FriendServices.Delete(f.FriendId);
            return RedirectToAction("List");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string friendname, string place)
        {
            Friend f = new Friend { FriendId = id, FriendName = friendname, Place = place };
            FriendServices.Update(f);
            return RedirectToAction("List");
        }
    }
}

