using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contact_Manage.Models
{
    public class PersonViewModel
    {
        public int PersonId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        public DateTime AddedOn { get; set; }

        public string AddedBy { get; set; }

        [Display(Name = "Home Address")]
        public string HomeAddress { get; set; }

        [Display(Name = "Home City")]
        [Required]
        public string HomeCity { get; set; }

        [Display(Name = "Facebook Account")]
        [Url]
        public string FaceBookAccountId { get; set; }

        [Display(Name = "LinkedIn Account")]
        [Url]
        public string LinkedInId { get; set; }

        [DataType(DataType.Date)]
        public DateTime? UpdateOn { get; set; }
        public string ImagePath { get; set; }

        [Display(Name = "Twitter Account")]
        [Url]
        public string TwitterId { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        [Required]
        public string EmailId { get; set; }

        public AspNetUser AspNetUser { get; set; }
        public Contact Contacts { get; set; }
    }
}