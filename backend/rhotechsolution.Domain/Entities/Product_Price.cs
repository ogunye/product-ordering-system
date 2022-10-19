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
    public class Product_Price 
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]   
        public int Product_ID { get; set; }

        [DataType(DataType.Date)]   
        public DateTime Date_From { get; set; }

        [DataType(DataType.Currency)]
        public decimal Product_Retail_Price { get; set; }

        [DataType(DataType.Currency)]
        public decimal Product_Wholesales_Price { get; set; }

        public virtual Product? Product { get; set; }
    }
}
