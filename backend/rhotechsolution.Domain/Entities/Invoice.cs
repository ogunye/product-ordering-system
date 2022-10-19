using rhotechsolution.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhotechsolution.Domain.Entities
{
    public class Invoice : BaseEntity
    {
        [ForeignKey(nameof(SalesOrder))]
        public int SaleOrder_ID { get; set; }        
    }
}
