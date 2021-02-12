using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MultiPageWebApp.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Number?.ToString();

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter phone number (without dashes).")]
        public Int64? Number { get; set; }

        [Required(ErrorMessage = "Please enter contact address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a note for contact.")]
        public string Note { get; set; }
        

    }
}
