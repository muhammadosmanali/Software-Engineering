using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contact_Manage.Models
{
    public class ContactViewModel
    {
        public int ContactId { get; set; }

        [Display(Name = "Contact Number")]
        [Required]
        public string ContactNumber { get; set; }

        [Required]
        public string Type { get; set; }
        public int PersonId { get; set; }

        public Person Person { get; set; }
    }
}