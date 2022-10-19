using rhotechsolution.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.Domain.Entities
{
    public class Product: BaseEntity
    {
        [Required(ErrorMessage ="This is a required field")]
        [MaxLength(100, ErrorMessage ="Maximum length is 100 characters")]
        public string? product_name { get; set; }

        [MaxLength(200, ErrorMessage = "Maximum length is 200 characters")]
        public string? product_description { get; set; }

        [MaxLength(4, ErrorMessage ="Max. character kength is 3")]
        public string? DiscontinueDate { get; set; }

        [ForeignKey(nameof(ProductCategory))]   
        public int product_category_id { get; set; }
        
        public int ProductQty { get; set; }
        public Guid rowguid { get; set; }
        public bool IsProductAvailable { get; set; }     

        public virtual Product_Price? Product_Price { get; set; }
    }
}
