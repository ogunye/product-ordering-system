using rhotechsolution.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rhotechsolution.Domain.Entities
{
    public class SalesOrder: BaseEntity
    {
        public DateTime OrderDate { get; set; }

        [MaxLength(10,ErrorMessage ="Max. character length is 10")]
        public string? SalesOrderStatus { get; set; }        

        [ForeignKey(nameof(Payment_Method))]
        public int PaymentMethod_ID { get; set; }
        public decimal Sub_Total { get; set; }
        public decimal VAT { get; set; }
        public decimal Total_Due { get; set; }
        public Guid rowguid { get; set; }

        public virtual Payment_Method? Payment_Method { get; set; }
    }
}