using rhotechsolution.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace rhotechsolution.Domain.Entities
{
    public class SalesPerson : BaseEntity
    {
        [Required, MaxLength(50, ErrorMessage ="Max. character length is 50")]
        public string? First_Name { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Max. character length is 50")]
        public string? LastName { get; set; }

        [Range(1,50)]
        public int NumberofClient { get; set; }

    }
}