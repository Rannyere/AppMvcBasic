using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasic.Models
{
    public class Provider : Entity
    {
        [Required(ErrorMessage = "{0} - Required field")]
        [StringLength(200, ErrorMessage = "The field {0} must be between {2} e {1} characteres", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} - Required field")]
        [StringLength(14, ErrorMessage = "The field {0} must be between {2} e {1} characteres", MinimumLength = 11)]
        public string Document { get; set; }


        public TypeProvider TypeProvider { get; set; }


        public Address Address { get; set; }

        [DisplayName("Activ?")]
        public bool Activ { get; set; }

        /* EF Relations */
        public IEnumerable<Product> Products { get; set; }
    }
}
