using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormDataValidation.Models
{
    public class Registration
    {
        public int ID { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(1)]
        [Display(Name = "Middle Initial")]
        public char MiddleInitial { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        [Required]
        public int ContactNumber { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [StringLength(16)]
        [Required]
        [Display(Name = "Username")]
        public char UserName { get; set; }
    }
}
