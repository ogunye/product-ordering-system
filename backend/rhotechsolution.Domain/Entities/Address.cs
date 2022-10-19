using rhotechsolution.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rhotechsolution.Domain.Entities
{
    public class Address : BaseEntity
    {
        [ForeignKey(nameof(Customer))]
        public int Customer_ID { get; set; }

        [Required, MaxLength(50)]
        public string? AddressType { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [Range(1, 500, ErrorMessage = "Number is between 1 and 500")]
        public int House_number { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Street_name { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Area_locality { get; set; } = null;

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Zip_postalcode { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Province_State { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Country { get; set; }

        public Guid rowguid { get; set; }

        public Customer? Customer { get; set; }
    }
}
