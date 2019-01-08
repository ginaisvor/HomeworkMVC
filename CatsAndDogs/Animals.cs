using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndDogs
{
    enum Colors { Black, White, Yellow };
    enum Genders { Male, Female };

    public class Animals
    {
        private string name;
        private string owner;
        private string color;
        private string gender;

        public string Name { get { return this.name; } }
        public string Owner { get { return this.owner; }}
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                if (String.Compare(value, Colors.Black.ToString(), ignoreCase: true) == 0 ||
                    String.Compare(value, Colors.White.ToString(), ignoreCase: true) == 0 ||
                    String.Compare(value, Colors.Yellow.ToString(), ignoreCase: true) == 0)
                {
                    this.color = value;
                }
                else
                {
                    this.color = "Unknown";
                }
            }
        }
        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if(String.Compare(value, Genders.Female.ToString(), ignoreCase:true) == 0 ||
                    String.Compare(value, Genders.Male.ToString(), ignoreCase: true) == 0)
                {
                    this.gender = value;

                }
                else
                {
                    this.gender = "unknown";
                         
                }
            }
        }

        public Animals()
        {
            this.name = "unknown";
            this.owner = "unknown";
            this.color = "unknown";
            this.gender = "unknown";
        }

        public Animals(string name, string owner, string color, string gender)
        {
            this.name = name;
            this.owner = owner;
            this.color = color;
            this.gender = gender;
        }
    }
}
