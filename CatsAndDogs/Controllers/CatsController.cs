using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatsAndDogs.NewFolder;
using CatsAndDogs.Services;
using Microsoft.AspNetCore.Mvc;

namespace CatsAndDogs.Controllers
{
    public class CatsController : Controller
    {
        private CatRepository catRepository;

        public CatsController()
        {
            catRepository = CatRepository.Instance;
        }

        public IActionResult List()
        {
            return View(catRepository.GetCats());
        }

        public IActionResult Edit(int id)
        {
            //var allExistingCats = catRepository.GetCats();
            Animals catToEdit = catRepository.GetCats().Find(x => x.Id == id);
            return View(catToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Animals model)
        {
            if (ModelState.IsValid)
            {
                var myCat = catRepository.GetCats().Find(x => x.Id == model.Id);
                TryUpdateModelAsync(myCat);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Animals());
        }

        [HttpPost]
        public IActionResult Create(Animals model)
        {
            if (ModelState.IsValid)
            {
                var maxId = catRepository.GetCats().Max(x => x.Id) + 1;
                model.Id = maxId;
                catRepository.AddCat(model);
                return RedirectToAction("List");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Animals catToDelete = catRepository.GetCats().Find(x => x.Id == id);
            return View(catToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Animals model)
        {
            var catToDelete = catRepository.GetCats().Find(x => x.Id == model.Id);
            catRepository.DeleteCat(catToDelete);
            //TryUpdateModelAsync(catRepository.GetCats());
            return RedirectToAction("List");
        }

        public IActionResult Index()
        {
            return View("Hy from cats.");
        }

        //public IActionResult Lista()
        //{
        //    var pisici = UmpleListaPisici();
        //    return View(pisici);
        //}

        [HttpGet]
        public IActionResult FilterColor(Colors color)
        {
            var myCat = catRepository.GetCats().Where(x => x.Color.Equals(color)).ToList();
            return View(myCat);
        }

        [HttpGet]
        public IActionResult FilterGender(Genders gender)
        {
            var myCat = catRepository.GetCats().Where(x => x.Gender.Equals(gender)).ToList();
            return View(myCat);
        }

    }
}
