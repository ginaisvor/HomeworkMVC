using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatsAndDogs.NewFolder;
using Microsoft.AspNetCore.Mvc;

namespace CatsAndDogs.Controllers
{
    public class DogsController : Controller
    {
        private DogRepository dogRepository;

        public DogsController()
        {
            dogRepository = DogRepository.Instance;
        }

        public IActionResult List()
        {
            return View(dogRepository.GetDogs());
        }

        public IActionResult Edit(int id)
        {
            var allExistingDogs = dogRepository.GetDogs();
            Animals dogToEdit = dogRepository.GetDogs().Find(x => x.Id == id);
            return View(dogToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Animals model)
        {
            if (ModelState.IsValid)
            {
                var myDog = dogRepository.GetDogs().Find(x => x.Id == model.Id);
                TryUpdateModelAsync(myDog);
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
                var maxId = dogRepository.GetDogs().Max(x => x.Id) + 1;

                model.Id = maxId;
                dogRepository.AddDog(model);
                return RedirectToAction("List");
            }
            return View(model);

        }

        public IActionResult Delete(int id)
        {
            Animals dogToDelete = dogRepository.GetDogs().Find(x => x.Id == id);
            return View(dogToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Animals model)
        {
            var dogToDelete = dogRepository.GetDogs().Find(x => x.Id == model.Id);
            dogRepository.DeleteDog(dogToDelete);
            TryUpdateModelAsync(dogRepository.GetDogs());
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult FilterColor(Colors color)
        {
            var myDog = dogRepository.GetDogs().Where(x => x.Color.Equals(color)).ToList();
            return View(myDog);
        }


        [HttpGet]
        public IActionResult FilterGender(Genders gender)
        {
            var myDog = dogRepository.GetDogs().Where(x => x.Gender.Equals(gender)).ToList();
            return View(myDog);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
