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
    public class Payment_Method : BaseEntity
    {
        public int Customer_Account { get; set; }

        [ForeignKey(nameof(Invoice))]
        public int Invoice_ID { get; set; }

        [Required(ErrorMessage ="This is a required field.")]
        public string? Transaction_Type { get; set; }
    }
}
