using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatsAndDogs
{
    public enum Colors { Black, White, Yellow, Unknown };
    public enum Genders { Male, Female, Unknown };

    public class Animals
    {
        private string name;
        private string owner;
        private Colors color;
        private Genders gender;

        public string Name { get { return this.name; } }
        public string Owner { get { return this.owner; }}
        public Colors Color
        {
            get
            {
                return this.color;
            }
            set
            {
                if (value == Colors.Black ||
                    value == Colors.White ||
                    value == Colors.Yellow)
                {
                    this.color = value;
                }
                else
                {
                    this.color = Colors.Unknown;
                }
            }
        }
        public Genders Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if(value == Genders.Female ||
                    value == Genders.Male)
                {
                    this.gender = value;

                }
                else
                {
                    this.gender = Genders.Unknown;
                         
                }
            }
        }

        public Animals()
        {
            this.name = "unknown";
            this.owner = "unknown";
            this.color = Colors.Unknown;
            this.gender = Genders.Unknown;
        }

        public Animals(string name, string owner, Colors color, Genders gender)
        {
            this.name = name;
            this.owner = owner;
            this.color = color;
            this.gender = gender;
        }
    }
}
