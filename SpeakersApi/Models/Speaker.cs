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
        [Required]
        public string ID { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Display(Name = "Mobile Number")]
        [Required]
        public string MobileNumber { get; set; }
        [Display(Name = "Area of Specialization")]
        [Required]
        public string Specialization { get; set; }
        [Display(Name = "City of Residence")]
        [Required]
        public string City { get; set; }
        [Display(Name = "Province of Residence")]
        [Required]
        public string Province { get; set; }
        [Required]
        public string Employer { get; set; }
    }
}