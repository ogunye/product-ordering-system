using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.Domain.Entities
{
    public class Customer_Address
    {
        [Required, ForeignKey(nameof(Customer))]
        public int customer_id { get; set; }

        [Required, ForeignKey(nameof(Address))]
        public int address_id { get; set; }

        [DataType(DataType.Date)]
        public DateTime date_from { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(5, ErrorMessage = "Maximum character length is 100 character.")]
        public string? address_type_code { get; set; }

        [MaxLength(200, ErrorMessage = "Maximum character length is 100 character.")]
        public string? customer_address_landmark { get; set; }
    }
}
