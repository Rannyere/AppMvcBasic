using System;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasic.Models
{
    public class Address : Entity
    {
        public Guid ProviderId { get; set; }

        [Required(ErrorMessage = "{0} - Required field")]
        [StringLength(200, ErrorMessage = "The field {0} must be between {2} e {1} characteres", MinimumLength = 2)]
        public string PublicPlace { get; set; }

        [Required(ErrorMessage = "{0} - Required field")]
        [StringLength(50, ErrorMessage = "The field {0} must be between {2} e {1} characteres", MinimumLength = 2)]
        public string Number { get; set; }

        [Required(ErrorMessage = "{0} - Required field")]
        [StringLength(200, ErrorMessage = "The field {0} must be between {2} e {1} characteres", MinimumLength = 2)]
        public string Complement { get; set; }

        [Required(ErrorMessage = "{0} - Required field")]
        [StringLength(8, ErrorMessage = "The field {0} must be between {2} e {1} characteres", MinimumLength = 2)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "{0} - Required field")]
        [StringLength(50, ErrorMessage = "The field {0} must be between {2} e {1} characteres", MinimumLength = 2)]
        public string Neighborhoodty { get; set; }

        [Required(ErrorMessage = "{0} - Required field")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} e {1} characteres", MinimumLength = 2)]
        public string City { get; set; }

        [Required(ErrorMessage = "{0} - Required field")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} e {1} characteres", MinimumLength = 2)]
        public string State { get; set; }

        /* Entity Framework Relations */
        public Provider Provider { get; set; }
    }
}
