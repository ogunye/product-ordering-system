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
    public class OrderDetail: BaseEntity
    {
        [Required(ErrorMessage ="This is a required field")]
        [ForeignKey(nameof(SalesOrder))]
        public int SalesOrderID { get; set; }

        [Required(ErrorMessage = "This is a required field")]
        [ForeignKey(nameof(Product))]
        public int Product_ID { get; set; }
             
        public int OrderQty { get; set; }
        public string? OrderType { get; set; }
        public decimal Unit_Price { get; set; }
        public decimal LineTotal { get; set; }
        public Guid rowguid { get; set; }       
    }
}
