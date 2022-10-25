using rhotechsolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.Application.DTOs.ProductDataTransferObjects
{
    public abstract record ProductForManipulationDto
    {
        [Required(ErrorMessage = "This is a required field")]
        [MaxLength(100, ErrorMessage = "Maximum length is 100 characters")]
        public string? product_name { get; set; }
        [MaxLength(200, ErrorMessage = "Maximum length is 200 characters")]
        public string? product_description { get; set; }
        [MaxLength(4, ErrorMessage = "Max. character kength is 3")]
        public string? DiscontinueDate { get; set; }       
        public int product_category_id { get; set; }
        [Range(0, int.MaxValue)]
        public int ProductQty { get; set; }        
        public bool IsProductAvailable { get; set; }
    }
}
