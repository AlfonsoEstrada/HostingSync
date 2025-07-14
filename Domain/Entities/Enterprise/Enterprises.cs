using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Enterprise
{
    [Table("Enterprises")]
    public class Enterprises
    {
        public Enterprises() { }
        public int EnterpriseId { get; set; }
        public string EnterpriseName { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int IsDeleted { get; set; }
    }
}
