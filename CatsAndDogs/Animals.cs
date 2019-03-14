using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CatsAndDogs
{
    public enum Colors { Black, White, Yellow};
    public enum Genders { Male, Female};

    public class Animals
    {
        public int Id { get; set; }
        public string NickName { get; set;}
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MinLength(2)]
        public string OwnerName { get; set; }
        [Required]
        [EmailAddress]
        public string OwnerEmail { get; set; }
        public Colors Color { get; set; }

        public Genders Gender { get; set; }
    }
}
