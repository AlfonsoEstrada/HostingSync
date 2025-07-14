using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Room.Dto
{
    public class RoomDto
    {
        public int IdRoom { get; set; }
        public string RoomName { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
        public int HotelId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int IsDeleted { get; set; }
    }
}
