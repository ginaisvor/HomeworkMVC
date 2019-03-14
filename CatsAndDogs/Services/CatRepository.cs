using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndDogs.Services
{
    public class CatRepository
    {
        static List<Animals> cats = new List<Animals>();
        private static CatRepository instance;

        public CatRepository()
        { }

        public static CatRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CatRepository();
                    cats = InitializeList();
                }
                return instance;
            }
        }

        private static List<Animals> InitializeList()
        {
            cats.Add(new Animals()
            {
                NickName = "Sever",
                DateOfBirth = DateTime.Parse("29.07.2017"),
                OwnerName = "Toader",
                OwnerEmail = "toader@gmail.com",
                Color = Colors.Black,
                Gender = Genders.Male
            });
            return cats;
        }

        public List<Animals> GetCats()
        {
            return cats;
        }

        public void AddCat(Animals catToAdd)
        {
            cats.Add(catToAdd);
        }

        public void DeleteCat(Animals catToDelete)
        {
            cats.Remove(catToDelete);
        }
    }
}
