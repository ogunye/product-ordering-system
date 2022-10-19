 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.Application.DTOs.ProductDataTransferObjects
{
    public class ProductInfoDto
    {
        public int Id { get; set; }
        public string? product_name { get; set; }
        public string? product_description { get; set; }
        public string? DiscontinueDate { get; set; }
        public int product_category_id { get; set; }
        public int ProductQty { get; set; }
        public bool IsProductAvailable { get; set; }

    }
}
