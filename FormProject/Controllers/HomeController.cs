using FormProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FormProject.Entity;
using FormProject.Data;

namespace FormProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

   

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(new PersonViewModel());
        }

        [HttpPost]
        public IActionResult Index(PersonViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new Person
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    Age = model.Age,
                    StartDate = model.StartDate
                };
                _context.Persons.Add(entity);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View("Kisiler", model);
        }

        public IActionResult Search(string q)
        {
            var aranan = _context.Persons.AsQueryable();
           
            if (!string.IsNullOrEmpty(q))
            {
                aranan = aranan.Where(m=>
                m.Name.ToLower().Contains(q.ToLower()) ||
                m.Surname.ToLower().Contains(q.ToLower()));
            }
            var model = new PersonsViewModel
            {
                Persons = aranan.ToList()
            };
            return View("Search" , model);
        }
        
        
        public IActionResult Kisiler()
        {
            return View(
                new PersonsViewModel
                {
                    Persons = _context.Persons.ToList()
                }
                );
        }


        public IActionResult Delete(int personId)
        {
            var entity = _context.Persons.Find(personId);
            if(entity != null)
            {
                _context.Persons.Remove(entity);
                _context.SaveChanges();
            }
            return RedirectToAction("Kisiler");
        }

        [HttpGet]
        public IActionResult PersonUpdate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _context.Persons.Select(m => new PersonViewModel
            {
                PersonId = m.PersonId,
                Name = m.Name,
                Surname = m.Surname,
                Age = m.Age,
                StartDate = m.StartDate

            }).FirstOrDefault(m => m.PersonId == id);

            if (entity == null)
            {
                return NotFound();
            }

            return View(entity);
        }



        [HttpPost]
        public IActionResult PersonUpdate(PersonViewModel model)
        {
            var entity = _context.Persons.Find(model.PersonId);

            if(entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            entity.Surname = model.Surname;
            entity.Age = model.Age;
            entity.StartDate = model.StartDate;

            _context.SaveChanges();
            return RedirectToAction("Kisiler");
           
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
