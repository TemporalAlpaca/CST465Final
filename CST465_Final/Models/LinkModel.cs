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

        [Required]
        public string linkAddress { get; set; }

        [Required]
        public string linkName { get; set; }

        [Required]
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
