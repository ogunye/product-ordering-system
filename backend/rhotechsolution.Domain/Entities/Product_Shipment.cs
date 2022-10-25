using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.Domain.Entities
{
    public class Product_Shipment
    {
        [Key]
        public int Shippment_ID { get; set; }

        [ForeignKey(nameof(SalesOrder)) ]
        public int SaleOrder_ID { get; set; }

        [ForeignKey(nameof(Customer))]
        public int Customer_ID { get; set; }

        [ForeignKey(nameof(Invoice))]
        public int Inovice_ID { get; set; }

        public string? TrackingNumber { get; set; }
        public DateTime DateShipped { get; set; }
        public DateTime DateDelivered { get; set; }

        public virtual Invoice? Invoice { get; set; }
    }
}
