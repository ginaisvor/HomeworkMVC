using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CatsAndDogs.Controllers
{


    public class CatsController : Controller
    {
        public IActionResult Index()
        {
            return View("Hy from cats.");
        }

        public IActionResult ListaPisici()
        {
            var pisici = UmpleListaPisici();
            return View(pisici);
        }
        [HttpGet]
        public IActionResult FilterName(string name)
        {
            var pisici = UmpleListaPisici();
            if (name != "")
            {
                pisici = pisici.Where(x => x.Name.Equals(name)).ToList();
                return View(pisici);
            }
            return View(pisici);
        }
        [HttpGet]
        public IActionResult FilterOwner(string owner)
        {
            var pisici = UmpleListaPisici();
            if (owner != "")
            {
                pisici = pisici.Where(x => x.Owner.Equals(owner)).ToList();
                return View(pisici);
            }
            return View(pisici);
        }

        [HttpGet]
        public IActionResult FilterNameAndOwner(string name, string owner)
        {
            var pisici = UmpleListaPisici();
            if (name != "" && owner != "")
            {
                pisici = pisici.Where(x => x.Name.Equals(name) && x.Owner.Equals(owner)).ToList();
                return View(pisici);
            }
            return View(pisici);
        }

        [HttpGet]
        public IActionResult FilterColor(Colors color)
        {
            var pisici = UmpleListaPisici();

            pisici = pisici.Where(x => x.Color.Equals(color)).ToList();
            return View(pisici);

        }

        public IActionResult FilterGender(Genders gender)
        {
            var pisici = UmpleListaPisici();
            pisici = pisici.Where(x => x.Gender.Equals(gender)).ToList();
            return View(pisici);
        }

        private List<Animals> UmpleListaPisici()
        {
            List<Animals> listaPisici = new List<Animals>();
            listaPisici.Add(new Animals("Mitza", "Popescu", Colors.White, Genders.Female));
            listaPisici.Add(new Animals("Riri", "Ionescu", Colors.Yellow, Genders.Male));
            listaPisici.Add(new Animals("Zuza", "Stoica", Colors.Black, Genders.Female));
            listaPisici.Add(new Animals("Sever", "Toader", Colors.Black,Genders.Male));
            Animals pis = new Animals();
            listaPisici.Add(pis);
            return listaPisici;
        }

    }
}
