using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Reservation
{
    [Table("Reservations")]
    public class Reservations
    {
        public Reservations() 
        {
            
        }

        public int IdReservation {  get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Status {  get; set; }
        public int PaymentId { get; set; }
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int IsDeleted { get; set;}


    }
}
