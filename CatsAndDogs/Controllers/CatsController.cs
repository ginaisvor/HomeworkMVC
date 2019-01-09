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
            return View("Lista cu toate pisicile.", pisici);
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
        public IActionResult FilterColor(string color)
        {
            var pisici = UmpleListaPisici();
            if(color != "")
            {
                pisici = pisici.Where(x => x.Color.Equals(color)).ToList();
                return View(pisici);
            }
            return View(pisici);
        }

        public IActionResult FilterGender(string gender)
        {
            var pisici = UmpleListaPisici();
            if (gender != "")
            {
                pisici = pisici.Where(x => x.Gender.Equals(gender)).ToList();
                return View(pisici);
            }
            return View(pisici);
        }

        private List<Animals> UmpleListaPisici()
        {
            List<Animals> listaPisici = new List<Animals>();
            listaPisici.Add(new Animals("Mitza", "Popescu", "white", "female"));
            listaPisici.Add(new Animals("Riri", "Ionescu", "Black", "male"));
            listaPisici.Add(new Animals("Zuza", "Stoica", "yellow", "female"));
            listaPisici.Add(new Animals("Sever", "Toader", "red","male"));
            Animals pis = new Animals();
            pis.Color = "Black";
            pis.Gender = "male";
            listaPisici.Add(pis);
            return listaPisici;
        }

    }
}
