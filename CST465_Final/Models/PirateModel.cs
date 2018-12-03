using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CST465_Final.Models
{
    public class PirateModel
    {
        public int id { get; set; }

        [Required]
        [Display(Name ="Name:")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Beard Color:")]
        public string beardColor { get; set; }

        [Required]
        [Display(Name = "Hat:")]
        public bool hasHat { get; set; }

        [Required]
        [Display(Name = "Number of Legs:")]
        public int numLegs { get; set; }

        [Required]
        [Display(Name = "Eyepatch:")]
        public bool hasEyepatch { get; set; }

        [Required]
        [Display(Name = "Catch Phrase:")]
        public string catchPhrase { get; set; }

        public PirateModel()
        {}


        public PirateModel(int ID, string n, string beardc, string phrase, int legs, bool hat, bool eyepatch)
        {
            id = ID;
            name = n;
            beardColor = beardc;
            catchPhrase = phrase;
            numLegs = legs;
            hasHat = hat;
            hasEyepatch = eyepatch;
        }
    }
}
