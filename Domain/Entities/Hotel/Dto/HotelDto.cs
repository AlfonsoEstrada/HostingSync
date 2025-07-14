using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Hotel.Dto
{
    public class HotelDto
    {
        public int IdHotel { get; set; }
        public string HotelName { get; set; }
        public string Abbreviation { get; set; }
        public string Ubication { get; set; }
        public int EnterpriseId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int IsDeleted { get; set; }
    }
}
