using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Payment
{
    [Table("Reservations")]
    public class Payment
    {
        public Payment() { }

        public int IdPayment { get; set; }
        public float Amount { get; set; }
        public string Method { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public int IsDeleted { get; set; }
    }
}
