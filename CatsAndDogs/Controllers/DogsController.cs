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
        public IActionResult FilterColor(string color)
        {
            var caini = UmpleListaCaini();
            if (color != "")
            {
                caini = caini.Where(x => x.Color.Equals(color)).ToList();
                return View(caini);
            }
            return View(caini);
        }

        public IActionResult FilterGender(string gender)
        {
            var caini = UmpleListaCaini();
            if (gender != "")
            {
                caini = caini.Where(x => x.Gender.Equals(gender)).ToList();
                return View(caini);
            }
            return View(caini);
        }


        private List<Animals> UmpleListaCaini()
        {
            List<Animals> listaCaini = new List<Animals>();
            listaCaini.Add(new Animals("Laika", "Popa", "white", "female"));
            listaCaini.Add(new Animals("Rex", "Kramer", "Black", "male"));
            listaCaini.Add(new Animals("Lady", "Farmer", "yellow", "female"));
            listaCaini.Add(new Animals("Dog", "Dumitriu", "red", "male"));
            return listaCaini;
        }

    }
}