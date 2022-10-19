using rhotechsolution.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.Domain.Entities
{
    public class ProductCategory : BaseEntity
    {
        [Required, MaxLength(50, ErrorMessage ="Maximum character length is 50.")]
        public string? Category_Name { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum character length is 50.")]
        public string?  Category_Description { get; set; }
    }
}
