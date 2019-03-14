using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndDogs.NewFolder
{
    public class DogRepository
    {
        static List<Animals> dogs = new List<Animals>();
        private static DogRepository instance;

        public DogRepository()
        { }

        public static DogRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DogRepository();
                    dogs = InitializeList();
                }
                return instance;
            }
        }

        private static List<Animals> InitializeList()
        {
            List<Animals> dogs = new List<Animals>();
            dogs.Add(new Animals()
            {
                NickName = "Riri",
                DateOfBirth = DateTime.Parse("15.03.2014"),
                OwnerName = "Ionescu",
                OwnerEmail = "ionescu@yahoo.com",
                Color = Colors.Yellow,
                Gender = Genders.Male
            });
            return dogs;
        }

        public List<Animals> GetDogs()
        {
            return dogs;
        }

        public void AddDog(Animals dogToAdd)
        {
            dogs.Add(dogToAdd);

        }

        public void DeleteDog(Animals dogToDelete)
        {
            dogs.Remove(dogToDelete);
        }
    }
}
