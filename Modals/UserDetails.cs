using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LostFound.Modals
{
    public class UserDetails
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        public string EmailId { get; set; }

        [MaxLength(10, ErrorMessage = "maximum length of phone number can be 10")]
        public string Phone { get; set; }

        public string Address { get; set; }

        [Required]
        public string Password { get; set; }

        public string SecurityQuestion { get; set; }

    }
}
