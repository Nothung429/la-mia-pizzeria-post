using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_post.Models;
using System.Reflection.Metadata.Ecma335;
using Microsoft.IdentityModel.Tokens;

namespace la_mia_pizzeria_post.Controllers
{
    public class PizzaController : Controller
    {
        public List<Pizza> CreatePizza()
        {
            List<Pizza> ListPizza = new List<Pizza> {

                new Pizza("Pizza Margherita", "bona come er pane", "https://media-assets.vanityfair.it/photos/61e444841e21bc3bd54b5357/1:1/w_2832,h_2832,c_limit/pizza%20tendenze.jpg", 3.99),
                new Pizza("Pizza Capricciosa", "idem co patate", "https://media-assets.vanityfair.it/photos/61e444841e21bc3bd54b5357/1:1/w_2832,h_2832,c_limit/pizza%20tendenze.jpg", 7.99),
                new Pizza("Pizza Diavola", "er duca", "https://media-assets.vanityfair.it/photos/61e444841e21bc3bd54b5357/1:1/w_2832,h_2832,c_limit/pizza%20tendenze.jpg", 12.99),
                new Pizza("Pizza Quattro Formaggi", "fiocina", "https://media-assets.vanityfair.it/photos/61e444841e21bc3bd54b5357/1:1/w_2832,h_2832,c_limit/pizza%20tendenze.jpg", 9.99),
                new Pizza("Pizza Coi Funghi", "er monnezza", "https://media-assets.vanityfair.it/photos/61e444841e21bc3bd54b5357/1:1/w_2832,h_2832,c_limit/pizza%20tendenze.jpg", 11.99),
                new Pizza("Pizza Salsiccia e Salame", "tonino u lurdu", "https://media-assets.vanityfair.it/photos/61e444841e21bc3bd54b5357/1:1/w_2832,h_2832,c_limit/pizza%20tendenze.jpg", 5.99),
            };

            return ListPizza;
        }

        // GET: PizzaController
        public ActionResult Index()
        {
            List<Pizza> ListPizza = CreatePizza();

            return View(ListPizza);
        }

        // GET: PizzaController/Details/5
        public ActionResult Details(int id)
        {
            List<Pizza> ListPizza = CreatePizza();

            return View(ListPizza[id]);
        }

        // GET: PizzaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pizza formData)
        {
            using (PizzeriaContext context = new PizzeriaContext())
            {
                Pizza postToCreate = new Pizza();
                postToCreate.Name = formData.Name;
                postToCreate.Description = formData.Description;
                postToCreate.Image = formData.Image;
                postToCreate.Price = formData.Price;

                context.Pizza.Add(postToCreate);

                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("Create");

            //Utility.Add(new Pizza(formData.Name, formData.Description, formData.Image, formData.Price));

            //return RedirectToAction("Index");
        }

        // POST: PizzaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
