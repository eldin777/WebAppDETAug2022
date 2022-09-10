using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Services;


namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);
        }

        public IActionResult Details(int id)
        {
            Pizza p = PizzaService.Get(id);
            return View(p);
        }

        public IActionResult List()
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);

        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id, string name, int size, decimal price, bool isglutenfree)
        {
            Pizza p = new Pizza { Id = id, Name = name, Size = (PizzaSize)size, Price = price, IsGlutenFree = isglutenfree };
            PizzaService.Add(p);
            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            Pizza p = PizzaService.Get(id);
            if (p != null)
                return View(p);
            else
                return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult Delete(Pizza p)
        {
            PizzaService.Delete(p.Id);
            return RedirectToAction("Delete");
        }
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, string name, PizzaSize size, decimal price, bool isglutenfree)
        {
            Pizza p = new Pizza { Id = id, Name = name, Size = (PizzaSize)size, Price = price, IsGlutenFree = isglutenfree };
            PizzaService.Update(p);
            return RedirectToAction("List");
        }
    }
}