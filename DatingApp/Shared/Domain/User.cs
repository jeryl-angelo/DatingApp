using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.Shared.Domain
{
    public class User: BaseDomainModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Username is too long!")]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Pronouns { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string GenderPreference { get; set; }
        [Required]
        public string AgePreference { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int ContactNum { get; set; }
        [Required]
        public string Location { get; set; }

       
    }
}
