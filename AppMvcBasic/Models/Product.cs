using System;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasic.Models
{
    public class Product : Entity
    {
        public Guid ProviderId { get; set; }

        [Required(ErrorMessage = "{0} - Required field")]
        [StringLength(200, ErrorMessage = "The field {0} must be between {2} e {1} characteres", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} - Required field")]
        [StringLength(1000, ErrorMessage = "The field {0} must be between {2} e {1} characteres", MinimumLength = 2)]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} - Required field")]
        [StringLength(200, ErrorMessage = "The field {0} must be between {2} e {1} characteres", MinimumLength = 2)]
        public string Image { get; set; }

        [Required(ErrorMessage = "{0} - Required field")]
        public decimal Value { get; set; }


        public DateTime DateRegister { get; set; }


        public bool Activ { get; set; }

        /* Entity Framework Relations */
        public Provider Provider { get; set; }
    }
}
