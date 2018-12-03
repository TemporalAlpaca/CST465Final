using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CST465_Final.Models
{
    public class PirateAnimalModel
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Name: ")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Species: ")]
        public string animalType { get; set; }

        [Required]
        [Display(Name = "Age: ")]
        public int age { get; set; }

        [Required]
        [Display(Name = "Speaks English: ")]
        public bool speaksEnglish { get; set; }

        public PirateAnimalModel(int ID, string n, string animal, int a, bool talks)
        {
            id = ID;
            name = n;
            animalType = animal;
            age = a;
            speaksEnglish = talks;
        }

        public PirateAnimalModel() { }
    }
}
