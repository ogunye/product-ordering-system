using rhotechsolution.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace rhotechsolution.Domain.Entities
{
    public class Ref_Address_Types: BaseEntity
    {
        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(5, ErrorMessage = "Maximum character length is 100 character.")]
        public string? address_type_code { get; set; }

        [MaxLength(200, ErrorMessage = "Maximum character length is 100 character.")]
        public string? address_type_description { get; set; }        
    }
}
