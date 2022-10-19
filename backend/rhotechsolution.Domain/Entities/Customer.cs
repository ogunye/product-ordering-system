using rhotechsolution.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rhotechsolution.Domain.Entities
{
    public class Customer: BaseEntity
    {
        [ForeignKey(nameof(SalesPerson))]
        public int SalePerson_ID { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? CustomerType { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Organisation_name { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? First_Name { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Middle_Name { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        [DataType(DataType.EmailAddress)]
        public string? Email_Address { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum character length is 100 character.")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone_Number { get; set; }

        public Guid rowguid { get; set; }

        public bool IsCustomerActive { get; set; }
    }
}
