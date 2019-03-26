using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactFormPage.Models
{
    public class Contact
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(16)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Subject { get; set; }

        [Required]
        [MaxLength(200)]
        public string Message { get; set; }

    }
}
