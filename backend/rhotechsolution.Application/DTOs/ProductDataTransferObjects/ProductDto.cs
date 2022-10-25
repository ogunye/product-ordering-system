 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.Application.DTOs.ProductDataTransferObjects
{
    public record ProductDto(string product_name,
    string product_description, string DiscontinueDate,
    int product_category_id,
    int ProductQty,
    bool IsProductAvailable);
    
}
