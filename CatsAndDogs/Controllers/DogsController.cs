using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CatsAndDogs.Controllers
{
    public class DogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaCaini()
        {
            var caini = UmpleListaCaini();
            return View(caini);
        }

        [HttpGet]
        public IActionResult FilterColor(Colors color)
        {
            var caini = UmpleListaCaini();
            caini = caini.Where(x => x.Color.Equals(color)).ToList();
            return View(caini);
        }

        public IActionResult FilterGender(Genders gender)
        {
            
            var caini = UmpleListaCaini();
            caini = caini.Where(x => x.Gender.Equals(gender)).ToList();
            return View(caini);
        }


        private List<Animals> UmpleListaCaini()
        {
            List<Animals> listaCaini = new List<Animals>();
            listaCaini.Add(new Animals("Laika", "Popa", Colors.White, Genders.Female));
            listaCaini.Add(new Animals("Rex", "Kramer", Colors.Black, Genders.Male));
            listaCaini.Add(new Animals("Lady", "Farmer", Colors.Yellow, Genders.Male));
            listaCaini.Add(new Animals("Dog", "Dumitriu", Colors.Unknown, Genders.Male));
            return listaCaini;
        }

    }
}