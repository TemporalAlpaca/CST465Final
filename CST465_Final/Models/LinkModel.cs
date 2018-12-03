using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class LinkModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Must enter a link address")]
        [Display(Name = "Link Address: ")]
        public string linkAddress { get; set; }

        [Required(ErrorMessage = "Must enter a link name")]
        [Display(Name = "Link Name: ")]
        public string linkName { get; set; }

        [Required(ErrorMessage = "Must enter a procrastination level between 1 and 10")]
        [Range(1,10)]
        [Display(Name = "Procrastination level: ")]
        public int pLevel { get; set; }

        public LinkModel(int id, string linkaddress, string linkname, int plevel)
        {
            Id = id;
            linkAddress = linkaddress;
            linkName = linkname;
            pLevel = plevel;
        }

        public LinkModel() { }
    }
}
