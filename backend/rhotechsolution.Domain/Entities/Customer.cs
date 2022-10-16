using rhotechsolution.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace rhotechsolution.Domain.Entities
{
    public class Customer: BaseEntity
    {
        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? customerType { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? organisation_name { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? first_name { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? middle_name { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? surname { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        [DataType(DataType.EmailAddress)]
        public string? email_address { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        [DataType(DataType.PhoneNumber)]
        public string? phone_number { get; set; }

        public bool IsCustomerActive { get; set; }
    }
}
