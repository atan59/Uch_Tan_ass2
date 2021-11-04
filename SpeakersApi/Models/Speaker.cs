using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpeakersApi.Models
{
    public class Speaker
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }
        [Display(Name = "Area of Specialization")]
        public string Specialization { get; set; }
        [Display(Name = "City of Residence")]
        public string City { get; set; }
        [Display(Name = "Province of Residence")]
        public string Province { get; set; }
        public string Employer { get; set; }
    }
}